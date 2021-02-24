<template>
  <div>
    <h1>Droid Gallery</h1>
    <table>
      <thead>
        <tr>
          <th class="robot-title">
            Droid
          </th>
          <th class="cost">
            Cost
          </th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(droid, index) in gallery" :key="index">
          <td class="droid-title">
            {{ droid.getBuild().head.title }}
          </td>
          <td class="cost">
            {{ droid.getTotalCost() }}
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script lang="ts">
import Built from "@/common/built";
import Vue from "vue";

export default Vue.extend({
  name: "DroidGallery",
  computed: {
    gallery(): Built[] {
      console.log(this.$store.state.gallery);
      return this.$store.state.gallery;
    }
  }
});
</script>
