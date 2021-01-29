<template>
  <div class="content">
    <button class="save-to-gallery" @click="saveToGallery()">
      Save to Gallery
    </button>
    <div class="top-row">
      <PartSelector :parts="builtCard.getBodyParts().heads" position="head" />
    </div>
    <div class="middle-row">
      <PartSelector :parts="builtCard.getBodyParts().arms" position="left" />
      <PartSelector
        :parts="builtCard.getBodyParts().torsos"
        position="center"
      />
      <PartSelector :parts="builtCard.getBodyParts().arms" position="right" />
    </div>
    <div class="bottom-row">
      <PartSelector :parts="builtCard.getBodyParts().bases" position="bottom" />
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import parts from "@/data/data";
import { BodyParts, Part, BuildSources } from "@/interfaces/common";
import { PropType } from "vue";
import PartSelector from "@/core/PartSelector.vue";

class Built {
  constructor(
    public headIndex: number = 0,
    public leftArmIndex: number = 0,
    public rightArmIndex: number = 0,
    public torsoIndex: number = 0,
    public baseIndex: number = 0
  ) {}

  getBuild(): BuildSources {
    return {
      head: parts.heads[this.headIndex],
      leftArm: parts.arms[this.leftArmIndex],
      rightArm: parts.arms[this.rightArmIndex],
      torso: parts.torsos[this.torsoIndex],
      base: parts.bases[this.baseIndex]
    };
  }
  getBodyParts(): BodyParts {
    return {
      heads: parts.heads,
      arms: parts.arms,
      torsos: parts.torsos,
      bases: parts.bases
    };
  }
}

@Component({
  components: {
    PartSelector
  }
})
export default class CardBuilder extends Vue {
  @Prop({
    type: Object as PropType<Built>,
    default: () => new Built()
  })
  builtCard!: Built;

  @Prop({
    type: Array as PropType<Array<Built>>,
    default: () => []
  })
  savedBuilds!: Array<Built>;

  // Computed Start
  get buildSource(): BuildSources {
    return this.builtCard.getBuild();
  }

  get saleBorderClass(): string {
    return this.buildSource.head.onSale ? "sale-border" : "";
  }
  // Computed end
  saveToGallery() {
    this.savedBuilds.push(this.builtCard);
  }

  getNextIndex(parts: Part[], index: number): number {
    if (parts.length - 1 > index) {
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
    this.builtCard.headIndex = this.getNextIndex(
      parts.heads,
      this.builtCard.headIndex
    );
  }

  selectPrevHead(): void {
    this.builtCard.headIndex = this.getPrevIndex(
      parts.heads,
      this.builtCard.headIndex
    );
  }

  selectNextLeftArm(): void {
    this.builtCard.leftArmIndex = this.getNextIndex(
      parts.arms,
      this.builtCard.leftArmIndex
    );
  }

  selectPrevLeftArm(): void {
    this.builtCard.leftArmIndex = this.getPrevIndex(
      parts.arms,
      this.builtCard.leftArmIndex
    );
  }

  selectNextRightArm(): void {
    this.builtCard.rightArmIndex = this.getNextIndex(
      parts.arms,
      this.builtCard.rightArmIndex
    );
  }

  selectPrevRightArm(): void {
    this.builtCard.rightArmIndex = this.getPrevIndex(
      parts.arms,
      this.builtCard.rightArmIndex
    );
  }

  selectNextBase(): void {
    this.builtCard.baseIndex = this.getNextIndex(
      parts.bases,
      this.builtCard.baseIndex
    );
  }

  selectPrevBase(): void {
    this.builtCard.baseIndex = this.getPrevIndex(
      parts.bases,
      this.builtCard.baseIndex
    );
  }

  selectNextTorso(): void {
    this.builtCard.torsoIndex = this.getNextIndex(
      parts.torsos,
      this.builtCard.torsoIndex
    );
  }

  selectPrevTorso(): void {
    this.builtCard.torsoIndex = this.getPrevIndex(
      parts.torsos,
      this.builtCard.torsoIndex
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

.build-name {
  position: absolute;
  top: -25px;
  text-align: center;
  width: 100%;
}

.content {
  position: relative;
}

.save-to-gallery {
  position: absolute;
  right: 30px;
  width: 220px;
  padding: 3px;
  font-size: 16px;
}
</style>
