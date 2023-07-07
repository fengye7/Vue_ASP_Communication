<template>
  <!--这里的按钮格式是随便找的不用在意，只是简单的测试-->
  <!--绑定数据、响应函数等需要v-指令的基本认识，不赘述-->

  <button type="button" class="btn btn-success" @click="GetParams">
    带参的Get请求测试
  </button>
  <button type="button" class="btn btn-primary" @click="PostParams">
    带参的POST请求测试
  </button>
  <button type="button" class="btn btn-secondary" @click="Delete">
    Delete请求测试
  </button>
  <button type="button" class="btn btn-danger" @click="Put">Put请求测试</button>
  <button type="button" class="btn btn-warning" @click="Head">
    Head请求测试
  </button>
  <button type="button" class="btn btn-info" @click="Options">
    Options请求测试
  </button>
  <button type="button" class="btn btn-light">Light</button>
  <button type="button" class="btn btn-dark">Dark</button>

  <button type="button" class="btn btn-link">Link</button>
</template>

<script>
import API from "../api/loginTest.js";

export default {
  //导出组件
  name: "TestView", //组件名
  methods: {
    //组件中可以使用的方法
    GetParams() {
      console.log("登录请求测试！");
      API({
        url: "/HelloWorld/GetParams",
        method: "get",
        params: {
          num: 123,
          str: " Test of params",
        },
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
    PostParams() {
      console.log("带参的POST请求测试");
      API({
        url: "/HelloWorld/PostParams/", //这里的url是会和你在api的js文件中basicUrl连接一起构成请求的url的
        method: "post",
        params: {
          num1: 7,
          num2: 5,
        },
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
    Delete() {
      console.log("Delete请求测试");
      API({
        url: "/HelloWorld/Delete/", //这里的url是会和你在api的js文件中basicUrl连接一起构成请求的url的
        method: "delete",
        params: null,
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
    Put() {
      console.log("Put请求测试");
      API({
        url: "/HelloWorld/Put/",
        method: "put",
        params: null,
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
    Head() {
      console.log("Head请求测试");
      API({
        url: "/HelloWorld/Head",
        method: "head",
        //params可省
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
    Options() {
      console.log("Options请求测试");
      API({
        url: "/HelloWorld/Options",
        method: "options",
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
  },
};
</script>

<style scoped>
</style>