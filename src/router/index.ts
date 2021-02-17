import Vue from "vue";
import Router from "vue-router";
import HomePage from "@/home/HomePage.vue";
import CardBuilder from "@/core/CardBuilder.vue";
import PartInfo from "@/core/PartInfo.vue";

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "Home",
      component: HomePage
    },
    {
      path: "/build",
      name: "Build",
      component: CardBuilder
    },
    {
      path: "/parts/:partType/:id",
      name: "Parts",
      component: PartInfo,
      props: true
    }
  ]
});
