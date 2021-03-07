<template>
  <div class="home">
    <div>
      <img
        class="fruits"
        src="@/assets/fruits.png"
        alt="fruits"
        aria-hidden="true"
      />
    </div>
    <div class="get-started">
      <router-link to="/build">Get started</router-link> planning your meals!
    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "HomePage"
});
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.home {
  text-align: center;
  margin-right: 25%;
}

.fruits {
  height: 300px;
}
</style>
