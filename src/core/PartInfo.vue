<template>
  <div>
    <h1>{{ part.title }}</h1>
    <div>
      {{ part.desc }}
    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import parts from "@/data/data";

interface PartInfo {
  title: string;
  desc: string;
}
export default Vue.extend({
  name: "PartInfo",
  props: ["partType", "id"],
  computed: {
    part(): PartInfo {
      const { partType, id } = this;
      const part = parts[partType].find(part => part.id === +id);

      return {
        title: part?.title ?? "No title found",
        desc: part?.description ?? "No description found"
      };
    }
  }
});
</script>
