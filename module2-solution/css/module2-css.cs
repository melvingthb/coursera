* {
  box-sizing: border-box;
  font-family: Helvetica;
  margin:0;
  padding:0;
}

.title {
  margin-top: 10px;
  text-align: center;
  font-size: 175%
}

.content {
  margin: 10px;
}

.section {
  background-color: lightgray;
  position: relative;
  margin: 10px;
}

.section_title {
  position: absolute;
  right: 0px;
  width: 150px;
  color: black;
  padding: 5px 40px 5px 40px;
  border: 1px solid black;
  font-size: 125%
}

.section_aramis {
  background-color: pink;
}
.section_athos {
  background-color: red;
  color: white;
}
.section_porthos {
  background-color: yellow;
}

.section_text {
    border: 1px solid black;
    padding: 40px 10px 10px 10px;
}

/********** Large devices only **********/
@media (min-width: 992px) {
  .col-lg-1, .col-lg-2, .col-lg-3 {
    float: left;
  }
  .col-lg-1 {
    width: 33.33%;
  }
  .col-lg-2 {
    width: 33.33%;
  }
  .col-lg-3 {
    width: 33.33%;
  }
}

/********** Medium devices only **********/
@media (min-width: 768px) and (max-width: 991px) {
  .col-md-6, .col-md-12 {
    float: left;
  }
  .col-md-6 {
    width: 50%;
  }
  .col-md-12 {
    width: 100%;
  }
}
