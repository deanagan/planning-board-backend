<template>
  <div id="app">
    <!-- Top Bar -->
    <b-navbar
      type="dark"
      variant="primary"
      class="flex-md-nowrap p-0 shadow nav-fill w-100"
      sticky
    >
      <b-navbar-brand class="col-md-3 col-lg-2 me-0 px-3"
        ><router-link class="nav-link" :to="{ name: 'Home' }" exact>
          <img class="logo" src="@/assets/tasks.png" alt="" />
          Planning Board
        </router-link></b-navbar-brand
      >

      <button
        class="navbar-toggler position-absolute d-md-none collapsed"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#sidebarMenu"
        aria-controls="sidebarMenu"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <input
        class="form-control form-control-dark w-100"
        type="text"
        placeholder="Search"
        aria-label="Search"
      />
      <b-navbar-nav class="px-3">
        <router-link class="nav-link" :to="{ name: 'Login' }" exact>
          <b-nav-item class="text-nowrap">Sign out</b-nav-item>
        </router-link>
      </b-navbar-nav>
    </b-navbar>

    <div class="main">
      <!-- Main Content -->
      <div class="content">
        <router-view />
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({});
</script>

<style>
.content {
  /* width: 1000px; */
  /* height: 720px; */
  /* margin-left: calc((100% - 1000px) / 2); */
  text-align: center;
  margin-top: 10px;
  overflow: hidden;
}

body {
  /* background: linear-gradient(to bottom, #555, #999); */
  background-attachment: fixed;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

main {
  padding: 30px;
  background-color: white;
  width: 80em;
}

/* .content {
  overflow: hidden;
height: 100%;
  max-width: 100%;
} */

header {
  background-color: #999;
  /* width: 1184px; */
  margin: 0 auto;
}

ul {
  padding: 3px;
  display: flex;
}
/*
.navbar-brand {
   margin-left: 10px;
}

.navbar-nav > li:last-child {
  margin-right: 120px;
} */
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

/* .container {
  display: flex;
  margin: 10px auto 0 auto;
  justify-content: center;
} */

/* .aside {
  padding: 30px;
  background-color: #aaa;
  width: 150px;
  min-height: 300px;
} */
/*
.viewpage {
  margin-left: 250px;
  align-content: center;
  height: 50vh;
} */
/*
.toplevel {
  width: 100vh;
  max-width: 100vh;
}

.sidebar-nav {
  float: left;
  height: 100%;
  width: 300px;
  max-width: 1024px;
  min-height: 400px;
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  overflow-x: hidden;
  box-sizing: border-box;
} */

/* .sidebar.nav {
  height: 100vh;
} */
</style>
