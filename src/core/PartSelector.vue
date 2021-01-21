<template>
  <div :class="[saleBorderClass, 'part']">
    <img :src="currentPart.src" title="head" />
    <button @click="getPreviousPart()" class="prev-selector">&#9668;</button>
    <button @click="getNextPart()" class="next-selector">&#9658;</button>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import { Part } from "@/interfaces/common";
import { PropType } from "vue";

@Component
export default class PartSelector extends Vue {
  @Prop({
    type: Array as PropType<Array<Part>>,
    required: true,
    default: () => []
  })
  parts!: Array<Part>;
  selectedIndex = 0;

  get currentPart(): Part {
    return this.parts[this.selectedIndex];
  }

  get saleBorderClass(): string {
    return this.currentPart.onSale ? "sale-border" : "";
  }

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

<style scoped>
.part {
  position: relative;
  width: 165px;
  height: 165px;
  border: 3px solid #aaa;
}

.part img {
  width: 165px;
}

.head {
  border-bottom: none;
}

.prev-selector {
  position: absolute;
  z-index: 1;
  top: -3px;
  left: -28px;
  width: 25px;
  height: 171px;
}
.next-selector {
  position: absolute;
  z-index: 1;
  top: -3px;
  right: -28px;
  width: 25px;
  height: 171px;
}

.sale-border {
  border: 3px solid red;
}
</style>
