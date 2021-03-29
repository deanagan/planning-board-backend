<template>
  <div class="gallery">
    <div class="reveal deck1">
      <!-- <div class="slides" style="border: 4px solid black;"> -->
      <div class="slides">
        <section>
          <div id="foo">
            <image-preview-uploader v-model="imageData" />
          </div>

          <!-- Styled -->
          <!-- <div class="row text-center" style="">
              <div
                class="col-xs-6 text-center"
                style="background-color:none; margin-top:10px; position: fixed; border: 2px solid black;"
              >
                <div class="product-holder">
                  <b-form-file
                    v-model="file"
                    ref="file-input"
                    class="product-image"
                    style="width:250px; height: 250px; opacity: 1; "
                  >
                  </b-form-file>

                  <img
                    :src="profile"
                    width="50px"
                    height="50px"
                    class="plus-image"
                    style=" margin-top: -20px;
 margin-left: -15px;
 transform: translate(-50%,-50%); position: absolute;"
                  />
                </div> -->

          <input type="reset" value="Clear" @click="clearImage" />

          <image-uploader
            id="fileInput1"
            :preview="true"
            class="my9"
            :className="['fileinput', { 'fileinput--loaded': hasImage }]"
            capture="environment"
            :debug="1"
            doNotResize="gif"
            :autoRotate="true"
            outputFormat="verbose"
            @input="setImage"
          >
            <label for="fileInput1" slot="upload-label">
              <figure class="plusHolder">
                <!-- <svg
                    xmlns="http://www.w3.org/2000/svg"
                    width="32"
                    height="32"
                    viewBox="0 0 32 32"
                  > -->
                <!-- <path
                      class="path1"
                      d="M9.5 19c0 3.59 2.91 6.5 6.5 6.5s6.5-2.91 6.5-6.5-2.91-6.5-6.5-6.5-6.5 2.91-6.5 6.5zM30 8h-7c-0.5-2-1-4-3-4h-8c-2 0-2.5 2-3 4h-7c-1.1 0-2 0.9-2 2v18c0 1.1 0.9 2 2 2h28c1.1 0 2-0.9 2-2v-18c0-1.1-0.9-2-2-2zM16 27.875c-4.902 0-8.875-3.973-8.875-8.875s3.973-8.875 8.875-8.875c4.902 0 8.875 3.973 8.875 8.875s-3.973 8.875-8.875 8.875zM30 14h-4v-2h4v2z"
                    ></path> -->
                <b-icon
                  v-show="!hasImage"
                  icon="plus"
                  aria-hidden="true"
                ></b-icon>
                <!-- </svg> -->
              </figure>
              <!-- <span class="upload-caption">{{
                  hasImage ? "Replace" : "Click to upload"
                }}</span> -->
            </label>
          </image-uploader>

          <!-- <div
                  class="col-xs-6 text-center"
                  style="background-color:none; margin-top:10px; position: fixed;"
                >
                  <b-img :src="upload" width="250" height="250" />
                  <b-img
                    :src="profile"
                    width="50px"
                    height="50px"
                    style="position:absolute; margin-top: 50%;
 margin-left: 50%;
 transform: translate(-50%,-50%);"
                  />

                </div> -->
        </section>
        <section>Vertical Slide 2</section>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
// import Reveal from '@/../node_modules/reveal.js/js/reveal';
import Vue from "vue";
import Reveal from "reveal.js/dist/reveal";
// import PictureInput from "vue-picture-input/PictureInput.vue";
import ImageUploader from "vue-image-upload-resize";

export default Vue.extend({
  name: "ReportGallery",
  data: () => {
    return {
      slides: {},
      upload: require("@/assets/tasks.png"),
      msg: "Vue Image Upload and Resize Demo",
      hasImage: false,
      image: {}
    };
  },
  components: {
    ImageUploader
  },
  computed: {
    // fileInput1() {
    //   return "fileInput1";
    // }
  },
  methods: {
    // onChange(image: any) {
    //   console.log("New picture selected!");
    //   if (image) {
    //     console.log("Picture loaded.");
    //     //this.image = image;
    //   } else {
    //     console.log("FileReader API not supported: use the <form>, Luke!");
    //   }
    // }
    clearImage() {
      this.hasImage = false;
      //const imgprev = document.querySelector(".my-8")?.querySelector('.img-preview') as HTMLCollectionOf<HTMLElement>;
      // TODO: use v-show

      // if (img) {
      //   console.log(imgprev?.className);
      // if (imgprev?.className) {
      //   //this.$refs[imgprev?.className].style.display = "none";
      // }
      //  imgprev?.style.display = "none";
      // elm?.style.display = "none";
      // console.log(elm);
      // }
      //document.removeChild(img);
    },
    // eslint-disable-next-line @typescript-eslint/no-explicit-any
    setImage: function(output: object) {
      this.hasImage = true;
      this.image = output;
      console.log("hello");
      console.log(typeof output);
      // TODO: use v-show

      // console.log('Info', output.info)
      // console.log('Exif', output.exif)
    }
  },

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

>>> #fileInput1 {
  display: none;
}

.img-preview {
  object-fit: stretch;
}

.my9 {
  border: 1px dashed black;
  width: 400px;
  height: 400px;
}

.plusHolder {
  width: 50px;
  height: 50px;
  position: absolute;
  left: -25;
  top: -10;
}

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
