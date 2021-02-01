<template>
  <div class="content">
    <button class="save-to-gallery" @click="saveToGallery()">
      Save to Gallery
    </button>
    <div class="top-row">
      <PartSelector
        :parts="builtCard.getBodyParts().heads"
        position="top"
        @partSelected="selectedIndex => (builtCard.headIndex = selectedIndex)"
      />
    </div>
    <div class="middle-row">
      <PartSelector
        :parts="builtCard.getBodyParts().arms"
        position="left"
        @partSelected="
          selectedIndex => (builtCard.leftArmIndex = selectedIndex)
        "
      />
      <PartSelector
        :parts="builtCard.getBodyParts().torsos"
        position="center"
        @partSelected="selectedIndex => (builtCard.torsoIndex = selectedIndex)"
      />
      <PartSelector
        :parts="builtCard.getBodyParts().arms"
        position="right"
        @partSelected="
          selectedIndex => (builtCard.rightArmIndex = selectedIndex)
        "
      />
    </div>
    <div class="bottom-row">
      <PartSelector
        :parts="builtCard.getBodyParts().bases"
        position="bottom"
        @partSelected="selectedIndex => (builtCard.baseIndex = selectedIndex)"
      />
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import parts from "@/data/data";
import { BuildSources } from "@/interfaces/common";
import { PropType } from "vue";
import PartSelector from "@/core/PartSelector.vue";
import Built from "@/common/built";

@Component({
  components: {
    PartSelector
  }
})
export default class CardBuilder extends Vue {
  @Prop({
    type: Object as PropType<Built>,
    default: () => new Built(parts)
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
    // Cloning instance including methods
    // Horrible syntax
    // The why:
    // 1. Object.create() creates a new object
    // 2. Object.getPrototypeOf() gets the prototype chain of the builtCard instance and adds it to the newly created object
    // 3. Object.assign() does copying of the instance variables into the new object
    const temp = Object.assign(
      Object.create(Object.getPrototypeOf(this.builtCard)),
      this.builtCard
    );

    this.savedBuilds.push(temp);
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
