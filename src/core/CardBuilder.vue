<template>
  <div class="content">
    <div class="preview">
      <CardPreview :selectedParts="builtCard.getBuild()" />
      <button class="save-to-gallery" @click="saveToGallery()">
        Save to Gallery
      </button>
    </div>
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
    <h1>Totals</h1>
    <table>
      <thead>
        <tr>
          <th>Card</th>
          <th class="cost">Cost</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(card, i) in savedBuilds" :key="i">
          <td>{{ card.getName() }}</td>
          <td class="cost">{{ card.getTotalCost() }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script lang="ts">
import { Vue } from "vue-property-decorator";
import { BodyParts } from "@/interfaces/common";
import PartSelector from "@/core/PartSelector.vue";
import Built from "@/common/built";
import CardPreview from "@/core/CardPreview.vue";
import createdHookMixin from "@/core/created-hook-mixin";

export default Vue.extend({
  name: "CardBuilder",
  mixins: [createdHookMixin],
  components: { PartSelector, CardPreview },
  data: () => {
    return {
      builtCard: new Built(),
      savedBuilds: [] as Built[]
    };
  },

  computed: {
    saleBorderClass(): string {
      return this.builtCard.getBuild().head.onSale ? "sale-border" : "";
    }
  },
  methods: {
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

      const totalCost = this.savedBuilds
        .map(e => e.getTotalCost())
        .reduce((total, current) => total + current);

      console.log(totalCost);
    },
    getBodyParts(): BodyParts {
      return this.builtCard.getBodyParts();
    }
  }
});
</script>

<style scoped>
.preview {
  position: absolute;
  top: -20px;
  right: 0;
  width: 210px;
  height: 210px;
  padding: 5px;
}
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
  width: 210px;
  padding: 3px;
  font-size: 16px;
}
</style>
