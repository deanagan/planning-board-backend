<template>
  <div>{{ part.description }}</div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import { Part } from "@/interfaces/common";
import { PropType } from "vue";

@Component
export default class PartSelector extends Vue {
  @Prop({
    type: Object as PropType<Array<Part>>,
    required: true,
    default: () => []
  })
  parts!: Array<Part>;
  selectedIndex = 0;

  getNextPart(): number {
    if (this.parts.length - 1 > this.selectedIndex) {
      this.selectedIndex += 1;
    } else {
      this.selectedIndex = 0;
    }
    return this.selectedIndex;
  }

  getPreviousPart(): number {
    if (this.selectedIndex > 0) {
      this.selectedIndex -= 1;
    } else {
      this.selectedIndex = this.parts.length - 1;
    }
    return this.selectedIndex;
  }
}
</script>

<style scoped></style>
