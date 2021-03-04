<template>
  <div id="app">
    <!-- <div id="app">
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
          <b-nav-item>
            <router-link class="nav-link" :to="{ name: 'Create' }" exact>
              Create
            </router-link>
          </b-nav-item>
        </b-navbar-nav>
-->
    <!-- Right aligned nav items -->
    <!--  <b-navbar-nav class="ml-auto">
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

            <template #button-content>
              <em>User</em>
            </template>
            <b-dropdown-item href="#">Profile</b-dropdown-item>
            <b-dropdown-item href="#">Sign Out</b-dropdown-item>
          </b-nav-item-dropdown>
        </b-navbar-nav>
      </b-collapse>
    </b-navbar>



    <b-container fluid="xl">
      <main>
        <router-view />
      </main>
    </b-container>
  </div> -->
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

    <b-navbar type="info" sticky class="bg-dark p-0">
      <!-- <div
      class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow"
    > -->
      <b-navbar-brand href="#" class="col-md-3 col-lg-2 me-0 px-3"
        ><router-link class="nav-link" :to="{ name: 'Home' }" exact>
          <img class="logo" src="@/assets/meal-plan.png" alt="" />
          Meal Planner
        </router-link></b-navbar-brand
      >
      <!-- <a class="navbar-brand col-md-3 col-lg-2 me-0 px-3" href="#"
        >Meal Planner</a
      > -->
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
      <!-- <ul class="navbar-nav  px-3">
        <li class="nav-item text-nowrap">
          <a class="nav-link" href="#">Sign out</a>
        </li>
      </ul> -->
    </b-navbar>
    <!-- </div> -->

    <b-container fluid>
      <div class="row content">
        <!-- <nav
          id="sidebarMenu"
          class="col-md-3 col-lg-2 d-md-block bg-light sidebar collapse"
        > -->

        <nav
          class="sidebarMenu"

        >
          <div class="position-sticky pt-3">
            <ul class="nav flex-column">
              <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="#">
                  <span data-feather="home"></span>
                  Dashboard
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="file"></span>
                  Orders
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="shopping-cart"></span>
                  Products
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="users"></span>
                  Customers
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="bar-chart-2"></span>
                  Reports
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="layers"></span>
                  Integrations
                </a>
              </li>
            </ul>

            <h6
              class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted"
            >
              <span>Saved reports</span>
              <a class="link-secondary" href="#" aria-label="Add a new report">
                <span data-feather="plus-circle"></span>
              </a>
            </h6>
            <ul class="nav flex-column mb-2">
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="file-text"></span>
                  Current month
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="file-text"></span>
                  Last quarter
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="file-text"></span>
                  Social engagement
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <span data-feather="file-text"></span>
                  Year-end sale
                </a>
              </li>
            </ul>
          </div>
        </nav>

        <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
          <div
            class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"
          >
            <h1 class="h2">Dashboard</h1>
            <div class="btn-toolbar mb-2 mb-md-0">
              <div class="btn-group me-2">
                <button type="button" class="btn btn-sm btn-outline-secondary">
                  Share
                </button>
                <button type="button" class="btn btn-sm btn-outline-secondary">
                  Export
                </button>
              </div>
              <button
                type="button"
                class="btn btn-sm btn-outline-secondary dropdown-toggle"
              >
                <span data-feather="calendar"></span>
                This week
              </button>
            </div>
          </div>

          <!-- <canvas
            class="my-4 w-100"
            id="myChart"
            width="900"
            height="380"
          ></canvas> -->

          <h2>Section title</h2>
          <div class="table-responsive" style="height: 1020">
            <table class="table table-striped table-sm">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Header</th>
                  <th>Header</th>
                  <th>Header</th>
                  <th>Header</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>1,001</td>
                  <td>random</td>
                  <td>data</td>
                  <td>placeholder</td>
                  <td>text</td>
                </tr>
                <tr>
                  <td>1,002</td>
                  <td>placeholder</td>
                  <td>irrelevant</td>
                  <td>visual</td>
                  <td>layout</td>
                </tr>
                <tr>
                  <td>1,003</td>
                  <td>data</td>
                  <td>rich</td>
                  <td>dashboard</td>
                  <td>tabular</td>
                </tr>
                <tr>
                  <td>1,003</td>
                  <td>information</td>
                  <td>placeholder</td>
                  <td>illustrative</td>
                  <td>data</td>
                </tr>
                <tr>
                  <td>1,004</td>
                  <td>text</td>
                  <td>random</td>
                  <td>layout</td>
                  <td>dashboard</td>
                </tr>
                <tr>
                  <td>1,005</td>
                  <td>dashboard</td>
                  <td>irrelevant</td>
                  <td>text</td>
                  <td>placeholder</td>
                </tr>
                <tr>
                  <td>1,006</td>
                  <td>dashboard</td>
                  <td>illustrative</td>
                  <td>rich</td>
                  <td>data</td>
                </tr>
                <tr>
                  <td>1,007</td>
                  <td>placeholder</td>
                  <td>tabular</td>
                  <td>information</td>
                  <td>irrelevant</td>
                </tr>
                <tr>
                  <td>1,008</td>
                  <td>random</td>
                  <td>data</td>
                  <td>placeholder</td>
                  <td>text</td>
                </tr>
                <tr>
                  <td>1,009</td>
                  <td>placeholder</td>
                  <td>irrelevant</td>
                  <td>visual</td>
                  <td>layout</td>
                </tr>
                <tr>
                  <td>1,010</td>
                  <td>data</td>
                  <td>rich</td>
                  <td>dashboard</td>
                  <td>tabular</td>
                </tr>
                <tr>
                  <td>1,011</td>
                  <td>information</td>
                  <td>placeholder</td>
                  <td>illustrative</td>
                  <td>data</td>
                </tr>
                <tr>
                  <td>1,012</td>
                  <td>text</td>
                  <td>placeholder</td>
                  <td>layout</td>
                  <td>dashboard</td>
                </tr>
                <tr>
                  <td>1,013</td>
                  <td>dashboard</td>
                  <td>irrelevant</td>
                  <td>text</td>
                  <td>visual</td>
                </tr>
                <tr>
                  <td>1,014</td>
                  <td>dashboard</td>
                  <td>illustrative</td>
                  <td>rich</td>
                  <td>data</td>
                </tr>
                <tr>
                  <td>1,015</td>
                  <td>random</td>
                  <td>tabular</td>
                  <td>information</td>
                  <td>text</td>
                </tr>
              </tbody>
            </table>
          </div>
        </main>
      </div>
    </b-container>
  </div>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({});
</script>

<style>
body {
  /* background: linear-gradient(to bottom, #555, #999); */
  background-attachment: fixed;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
}

/* .container {

 max-width: 100%;
} */
main {
  padding: 30px;
  background-color: white;
  width: 80em;
  /*min-height: 300px; */
}

.content {
   display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
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
  /* margin-left: 10px; */
}

.navbar-nav > li:last-child {
  margin-right: 120px;
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

/* .container {
  display: flex;
  margin: 10px auto 0 auto;
  justify-content: center;
} */

.aside {
  padding: 30px;
  background-color: #aaa;
  width: 150px;
  min-height: 300px;
}
</style>
