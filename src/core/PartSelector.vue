<template>
  <div>{{ part.description }}</div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import { Part } from "@/interfaces/common";
import { PropType } from "vue";

@Component({
  props: ["part"]
})
export default class PartSelector extends Vue {
  @Prop({
    type: Object as PropType<Part>,
    required: true
  })
  part!: Part;
}
</script>

<style scoped></style>
