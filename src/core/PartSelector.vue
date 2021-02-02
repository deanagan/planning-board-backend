<template>
  <div :class="[saleBorderClass, 'part', position]">
    <img :src="currentPart.src" :title="position" />
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

  @Prop({
    type: String,
    required: true,
    default: () => "",
    validator: (value: string): boolean =>
      ["top", "left", "right", "center", "bottom"].includes(value)
  })
  position!: string;

  selectedIndex = 0;

  created() {
    this.$emit("partSelected", this.selectedIndex);
  }

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
    this.$emit("partSelected", this.selectedIndex);
    return this.selectedIndex;
  }

  getPreviousPart(): number {
    if (this.selectedIndex > 0) {
      this.selectedIndex -= 1;
    } else {
      this.selectedIndex = this.parts.length - 1;
    }
    this.$emit("partSelected", this.selectedIndex);
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

.top {
  border-bottom: none;
}
.left {
  border-right: none;
}
.right {
  border-left: none;
}
.left img {
  transform: rotate(-90deg);
}
.right img {
  transform: rotate(90deg);
}
.bottom {
  border-top: none;
}

.center .prev-selector,
.center .next-selector {
  opacity: 0.8;
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

.left .prev-selector {
  top: -28px;
  left: -3px;
  width: 144px;
  height: 25px;
}
.left .next-selector {
  top: auto;
  bottom: -28px;
  left: -3px;
  width: 144px;
  height: 25px;
}
.right .prev-selector {
  top: -28px;
  left: 24px;
  width: 144px;
  height: 25px;
}
.right .next-selector {
  top: auto;
  bottom: -28px;
  left: 24px;
  width: 144px;
  height: 25px;
}
.right .next-selector {
  right: -3px;
}

.sale-border {
  border: 3px solid red;
}
</style>
