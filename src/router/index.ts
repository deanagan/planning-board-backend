import Vue from "vue";
import Router from "vue-router";
import HomePage from "@/home/HomePage.vue";
import CardBuilder from "@/core/CardBuilder.vue";
import PartInfo from "@/core/PartInfo.vue";
import BrowseParts from "@/core/BrowseParts.vue";
import CardArms from "@/core/CardArms.vue";
import CardHeads from "@/core/CardHeads.vue";
import CardBases from "@/core/CardBases.vue";
import CardTorsos from "@/core/CardTorsos.vue";
import NotFound from "@/core/NotFound.vue";
import SidebarDefault from "@/sidebars/SidebarDefault.vue";
import SidebarBuild from "@/sidebars/SidebarBuild.vue";

Vue.use(Router);

export default new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/",
      name: "Home",
      components: {
        default: HomePage,
        sidebar: SidebarDefault
      }
    },
    {
      path: "*",
      name: "NotFound",
      component: NotFound
    },
    {
      path: "/build",
      name: "Build",
      components: {
        default: CardBuilder,
        sidebar: SidebarBuild
      }
    },
    // This must come before part info below
    {
      path: "/parts/browse",
      name: "BrowseParts",
      component: BrowseParts,
      children: [
        {
          name: "BrowseHeads",
          path: "heads",
          component: CardHeads
        },
        {
          name: "BrowseArms",
          path: "arms",
          component: CardArms
        },
        {
          name: "BrowseBases",
          path: "bases",
          component: CardBases
        },
        {
          name: "BrowseTorsos",
          path: "torsos",
          component: CardTorsos
        }
      ]
    },
    {
      path: "/parts/:partType/:id",
      name: "Parts",
      component: PartInfo,
      props: true,
      beforeEnter(to, _from, next) {
        const isValidId = !Number.isNaN(+to.params.id);
        if (isValidId) {
          next();
        } else {
          next({ name: "Build" });
        }
      }
    }
  ]
});
