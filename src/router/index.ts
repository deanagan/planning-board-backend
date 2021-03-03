import Vue from "vue";
import Router from "vue-router";
import HomePage from "@/home/HomePage.vue";
import DroidBuilder from "@/core/DroidBuilder.vue";
import PartInfo from "@/core/PartInfo.vue";
import BrowseParts from "@/core/BrowseParts.vue";
import DroidArms from "@/core/DroidArms.vue";
import DroidHeads from "@/core/DroidHeads.vue";
import DroidBases from "@/core/DroidBases.vue";
import DroidTorsos from "@/core/DroidTorsos.vue";
import NotFound from "@/core/NotFound.vue";
import SidebarDefault from "@/sidebars/SidebarDefault.vue";
import SidebarBuild from "@/sidebars/SidebarBuild.vue";
import DroidGallery from "@/gallery/DroidGallery.vue";
import LoginPage from "@/login/LoginPage.vue";

Vue.use(Router);

export const router = new Router({
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
      path: "/create",
      name: "Create",
      components: {
        default: DroidBuilder,
        sidebar: SidebarBuild
      }
    },
    {
      path: "/login",
      name: "LoginPage",
      component: LoginPage
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
          component: DroidHeads
        },
        {
          name: "BrowseArms",
          path: "arms",
          component: DroidArms
        },
        {
          name: "BrowseBases",
          path: "bases",
          component: DroidBases
        },
        {
          name: "BrowseTorsos",
          path: "torsos",
          component: DroidTorsos
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
    },
    {
      path: "/gallery",
      name: "DroidGallery",
      component: DroidGallery
    }
  ]
});

// router.beforeEach((to, _from, next) => {
//   const publicPages = ["/login", "/"];
//   const authRequired = !publicPages.includes(to.path);
//   const loggedIn = localStorage.getItem("token");

//   if (authRequired && !loggedIn) {
//     console.log(to.name);
//     next({ name: "LoginPage", query: { redirect: to.name } });
//   } else {
//     next();
//   }
// });
