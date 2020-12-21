<template>
  <div>
    <div class="top-row">
      <div class="top part">
        <img :src="parts.heads[selectedHeadIndex].src" title="head" />
        <button @click="selectPrevHead()" class="prev-selector">&#9668;</button>
        <button @click="selectNextHead()" class="next-selector">&#9658;</button>
      </div>
    </div>
    <div class="middle-row">
      <div class="left part">
        <img :src="parts.arms[selectedLeftArmIndex].src" title="left arm" />
        <button @click="selectPrevLeftArm()" class="prev-selector">
          &#9650;
        </button>
        <button @click="selectNextLeftArm()" class="next-selector">
          &#9660;
        </button>
      </div>
      <div class="center part">
        <img :src="parts.torsos[selectedTorsoIndex].src" title="torso" />
        <button @click="selectPrevTorso()" class="prev-selector">
          &#9668;
        </button>
        <button @click="selectNextTorso()" class="next-selector">
          &#9658;
        </button>
      </div>
      <div class="right part">
        <img :src="parts.arms[selectedRightArmIndex].src" title="right arm" />
        <button @click="selectPrevRightArm()" class="prev-selector">
          &#9650;
        </button>
        <button @click="selectNextRightArm()" class="next-selector">
          &#9660;
        </button>
      </div>
    </div>
    <div class="bottom-row">
      <div class="bottom part">
        <img :src="parts.bases[selectedBaseIndex].src" title="legs" />
        <button @click="selectPrevBase()" class="prev-selector">&#9668;</button>
        <button @click="selectNextBase()" class="next-selector">&#9658;</button>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import parts, { Part } from "@/data/data";

@Component
export default class CardBuilder extends Vue {
  @Prop({ default: 0 })
  selectedHeadIndex!: number;
  @Prop({ default: 0 })
  selectedLeftArmIndex!: number;
  @Prop({ default: 0 })
  selectedRightArmIndex!: number;
  @Prop({ default: 0 })
  selectedTorsoIndex!: number;
  @Prop({ default: 0 })
  selectedBaseIndex!: number;

  data() {
    return { parts };
  }

  getNextIndex(parts: Part[], index: number): number {
    if (parts.length > index) {
      index += 1;
    } else {
      index = 0;
    }
    return index;
  }

  getPrevIndex(parts: Part[], index: number): number {
    if (index > 0) {
      index -= 1;
    } else {
      index = parts.length - 1;
    }
    return index;
  }

  selectNextHead(): void {
    this.selectedHeadIndex = this.getNextIndex(
      parts.heads,
      this.selectedHeadIndex
    );
  }

  selectPrevHead(): void {
    this.selectedHeadIndex = this.getPrevIndex(
      parts.heads,
      this.selectedHeadIndex
    );
  }

  selectNextLeftArm(): void {
    this.selectedLeftArmIndex = this.getNextIndex(
      parts.arms,
      this.selectedLeftArmIndex
    );
  }

  selectPrevLeftArm(): void {
    this.selectedLeftArmIndex = this.getPrevIndex(
      parts.arms,
      this.selectedLeftArmIndex
    );
  }

  selectNextRightArm(): void {
    this.selectedRightArmIndex = this.getNextIndex(
      parts.arms,
      this.selectedRightArmIndex
    );
  }

  selectPrevRightArm(): void {
    this.selectedRightArmIndex = this.getPrevIndex(
      parts.arms,
      this.selectedRightArmIndex
    );
  }

  selectNextBase(): void {
    this.selectedBaseIndex = this.getNextIndex(
      parts.bases,
      this.selectedBaseIndex
    );
  }

  selectPrevBase(): void {
    this.selectedBaseIndex = this.getPrevIndex(
      parts.bases,
      this.selectedBaseIndex
    );
  }

  selectNextTorso(): void {
    this.selectedTorsoIndex = this.getNextIndex(
      parts.torsos,
      this.selectedTorsoIndex
    );
  }

  selectPrevTorso(): void {
    this.selectedTorsoIndex = this.getPrevIndex(
      parts.torsos,
      this.selectedTorsoIndex
    );
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
.top-row {
  display: flex;
  justify-content: space-around;
}
.middle-row {
  display: flex;
  justify-content: center;
}
.bottom-row {
  display: flex;
  justify-content: space-around;
  border-top: none;
}
.head {
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
.center .prev-selector,
.center .next-selector {
  opacity: 0.8;
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
</style>
