<template>
  <div class="gallery">
    <div class="reveal deck1">
      <!-- <div class="slides" style="border: 4px solid black;"> -->
      <div class="slides" style="z-index: 5">
        <section>Vertical Slide 1</section>
        <section>Vertical Slide 2</section>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
// import Reveal from '@/../node_modules/reveal.js/js/reveal';
import Vue from "vue";
import Reveal from "reveal.js/dist/reveal";

export default Vue.extend({
  data: () => {
    return {
      slides: {}
    };
  },
  components: {},
  mounted() {
    // if (window.location.search.match(/print-pdf/gi)) {
    //   const link = document.createElement("link");
    //   link.rel = "stylesheet";
    //   link.type = "text/css";
    //   link.href = "reveal.js/css/print/pdf.scss";
    //   document.getElementsByTagName("head")[0].appendChild(link);
    // }

    // this.slides = new Reveal(document.querySelector(".deck1"), {
    //   embedded: true,
    //   keyboardCondition: "focused",
    //   //hash: false, // we want this commented out so the url doesn't have hashes/ slide numbering

    //   // Learn about plugins: https:/revealjs.com/plugins/
    //   // plugins: [ RevealMarkdown, RevealHighlight, RevealNotes ],
    //   dependencies: [],
    //   width: 1280,
    //   height: 720,
    //   pdfSeparateFragments: false,
    //   pdfMaxPagesPerSlide: 1,
    //   center: true
    // });

    this.slides = new Reveal(document.querySelector(".deck1"), {
      embedded: true,
      keyboardCondition: "focused",
      //hash: false, // we want this commented out so the url doesn't have hashes/ slide numbering

      // Learn about plugins: https:/revealjs.com/plugins/
      // plugins: [ RevealMarkdown, RevealHighlight, RevealNotes ],
      dependencies: [],
      width: 1280,
      height: 720,

      pdfSeparateFragments: false,
      pdfMaxPagesPerSlide: 1,
      center: true,
      controlsLayout: "edges"
    }).initialize();

    // let revealSlide = document.querySelector(".reveal") as Reveal;
    // revealSlide.style.width = "50vw";
    // let reveadocument?.querySelector( '.reveal' ).style.width = '50vw';

    //this.slides.initialize();
    // window.Reveal = Reveal;
    // this.slideinstance.initialize({
    //   hash: true,

    //   // Learn about plugins: https:/revealjs.com/plugins/
    //   // plugins: [ RevealMarkdown, RevealHighlight, RevealNotes ],
    //   dependencies: [],
    //   width: 1280,
    //   height: 720,
    //   pdfSeparateFragments: false,
    //   pdfMaxPagesPerSlide: 1,
    //   embedded: false,
    //   center: true
    // });
  }
});
</script>

<style scoped>
@import url("../../node_modules/reveal.js/dist/reveal.css");
@import url("../../node_modules/reveal.js/dist/theme/white.css");

@import url("../../node_modules/bootstrap/dist/css/bootstrap.css");
@import url("../../node_modules/bootstrap-vue/dist/bootstrap-vue.css");

.gallery {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  /* margin-top: 60px; */
  height: 100vh;

  /* width: 100vw; */
  /* width: 100%; */
  margin-top: -20px;
  margin-left: -160px;
  border-left: 0px;
  padding-bottom: 0px;
  max-width: 1380px;
  max-height: 860px;
}

.reveal {
  text-align: center;
  /* height: 700px; */
  /* position: relative; */
  background-color: aqua;
}

.reveal h6 {
  text-transform: none;
}

.reveal h5 {
  text-transform: none;
}

.reveal p {
  text-align: center;
}

.reveal .print-pdf {
  /* width: 100px; */
  padding-left: 0px;
  margin: 0px;
}

/* .reveal .section {
  width: 100%;
} */

div .slide-background-content {
  margin-left: 0px;
  opacity: 0.1;
}

.card-body {

  padding-left: 2px;
  padding-right: 2px;

}
</style>
