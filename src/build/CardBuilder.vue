<template>
  <div class="content">
    <button class="save-to-gallery" @click="saveToGallery()">
      Save to Gallery
    </button>
    <div class="top-row">
      <div class="build-name">
        {{ buildSource.head.title }}
        <span v-show="buildSource.head.onSale" class="hot">Hot!</span>
      </div>
      <div class="top part">
        <img :src="buildSource.head.src" title="head" />
        <button @click="selectPrevHead()" class="prev-selector">&#9668;</button>
        <button @click="selectNextHead()" class="next-selector">&#9658;</button>
      </div>
    </div>
    <div class="middle-row">
      <div class="left part">
        <img :src="buildSource.leftArm.src" title="left arm" />
        <button @click="selectPrevLeftArm()" class="prev-selector">
          &#9650;
        </button>
        <button @click="selectNextLeftArm()" class="next-selector">
          &#9660;
        </button>
      </div>
      <div class="center part">
        <img :src="buildSource.torso.src" title="torso" />
        <button @click="selectPrevTorso()" class="prev-selector">
          &#9668;
        </button>
        <button @click="selectNextTorso()" class="next-selector">
          &#9658;
        </button>
      </div>
      <div class="right part">
        <img :src="buildSource.rightArm.src" title="right arm" />
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
        <img :src="buildSource.base.src" title="legs" />
        <button @click="selectPrevBase()" class="prev-selector">&#9668;</button>
        <button @click="selectNextBase()" class="next-selector">&#9658;</button>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import parts, { Part } from "@/data/data";
import { PropType } from "vue";

interface BuildSources {
  head: Part;
  leftArm: Part;
  rightArm: Part;
  torso: Part;
  base: Part;
}

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

}

@Component
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

  get buildSource(): BuildSources {
    return this.builtCard.getBuild();
  }

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

.build-name {
  position: absolute;
  top: -25px;
  text-align: center;
  width: 100%;
}

.content {
  position: relative;
}

.hot {
  color: red;
}

.save-to-gallery {
  position: absolute;
  right: 30px;
  width: 220px;
  padding: 3px;
  font-size: 16px;
}
</style>
