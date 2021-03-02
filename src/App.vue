<template>
  <div id="app">
    <b-navbar toggleable="sm" type="dark" variant="primary">
      <b-navbar-brand href="#"
        ><router-link class="nav-link" :to="{ name: 'Home' }" exact>
          <img class="logo" src="@/assets/meal-plan.png" alt="" />
          Meal Planner
        </router-link></b-navbar-brand
      >

      <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

      <b-collapse id="nav-collapse" is-nav>
        <b-navbar-nav>
          <b-nav-item href="#">Link</b-nav-item>

          <b-nav-item href="#" disabled>Disabled</b-nav-item>
        </b-navbar-nav>

        <!-- Right aligned nav items -->
        <b-navbar-nav class="ml-auto">
          <b-nav-form>
            <b-form-input
              size="sm"
              class="mr-sm-2"
              placeholder="Search"
            ></b-form-input>
            <b-button size="sm" class="my-2 my-sm-0" type="submit"
              >Search</b-button
            >
          </b-nav-form>

          <b-nav-item-dropdown text="Lang" right>
            <b-dropdown-item href="#">EN</b-dropdown-item>
            <b-dropdown-item href="#">ES</b-dropdown-item>
            <b-dropdown-item href="#">RU</b-dropdown-item>
            <b-dropdown-item href="#">FA</b-dropdown-item>
          </b-nav-item-dropdown>

          <b-nav-item-dropdown right>
            <!-- Using 'button-content' slot -->
            <template #button-content>
              <em>User</em>
            </template>
            <b-dropdown-item href="#">Profile</b-dropdown-item>
            <b-dropdown-item href="#">Sign Out</b-dropdown-item>
          </b-nav-item-dropdown>
        </b-navbar-nav>
      </b-collapse>
    </b-navbar>
  </div>
  <!--
  <div id="app">
    <header>
      <nav>
        <ul>
          <li class="nav-item">
            <router-link class="nav-link" :to="{ name: 'Home' }" exact>
              <img class="logo" src="@/assets/meal-plan.png" alt="" />
              Droid Builder
            </router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" :to="{ name: 'Build' }" exact>
              <img class="logo" alt="" />
              Build
            </router-link>
          </li>
          <li class="nav-item gallery">
            <router-link class="nav-link" to="/gallery" exact>
              <img class="logo" alt="" />
              Gallery
            </router-link>
          </li>
          <li class="nav-item gallery mt-5">
            <router-link class="nav-link" to="/gallery" exact>
              <img class="logo" alt="" />
              Log Out
            </router-link>
          </li>
        </ul>
      </nav>
    </header>
    <div class="container">
      <aside class="aside">
        <router-view name="sidebar" />
      </aside>
      <main>
        <router-view />
      </main>
    </div>
  </div> -->
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({});
</script>

<style>
body {
  background: linear-gradient(to bottom, #555, #999);
  background-attachment: fixed;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
}

main {
  padding: 30px;
  background-color: white;
  /* width: 964px; */
  min-height: 300px;
}

header {
  background-color: #999;
  /* width: 1184px; */
  margin: 0 auto;
}

ul {
  padding: 3px;
  display: flex;
}

.navbar-brand {
  margin-left: 200px;
}

.navbar-nav > li:last-child {
  margin-right: 100px;
}
/*
.nav-item {
  display: inline-block;
  padding: 5px 10px;
  font-size: 22px;
  border-right: 1px solid #bbb;
}

.nav-item.cart {
  position: relative;
  margin-left: auto;
  border-right: none;
} */

.logo {
  vertical-align: middle;
  height: 30px;
}

.nav-link {
  text-decoration: None;
  color: inherit;
}

.router-link-active {
  color: white;
}

.container {
  display: flex;
  margin: 10px auto 0 auto;
  justify-content: center;
}

.aside {
  padding: 30px;
  background-color: #aaa;
  width: 150px;
  min-height: 300px;
}
</style>
