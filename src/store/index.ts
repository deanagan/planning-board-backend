import Built from "@/common/built";
import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);
// TODO: Typescript approach
export default new Vuex.Store({
  state: {
    gallery: [] as Built[]
  },
  mutations: {
    addDroidToGallery(state, droid) {
      state.gallery.push(droid);
    }
  }
});
