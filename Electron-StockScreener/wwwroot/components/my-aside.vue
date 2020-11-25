<!--左側選取欄-->
<template>
  <div>
      <el-menu default-active="2" class="el-menu-vertical-demo" :collapse="flag" :router="true">
          <el-menu-item v-on:click="hamb">
              <i class="el-icon-arrow-right" v-show="flag"></i>
              <i class="el-icon-arrow-left" v-show="!flag"></i>
              <span slot="title" v-show="!flag">收起選單</span>
              <span slot="title" v-show="flag">展開選單</span>
          </el-menu-item>
         
          <el-menu-item v-for="item in menuList" v-bind:index="item.router">
              <i v-bind:class="item.icon"></i>
              <span slot="title">{{item.name}}</span>
          </el-menu-item>
      </el-menu>
  </div>
</template>

<script>
module.exports = {
  name: "my-aside",
  data() {
    return {
        flag: false,
        menuList: [
            { name: '測試', router: '/', icon: 'el-icon-menu' },
            { name: '測試', router: '/', icon: 'el-icon-menu' },
            { name: '測試', router: '/', icon: 'el-icon-menu' },
            { name: '測試', router: '/', icon: 'el-icon-menu' },
            { name: '測試', router: '/', icon: 'el-icon-menu' },
            { name: '測試', router: '/', icon: 'el-icon-menu' },
        ]
    };
  },
  methods: {
    hamb() {
      this.flag = !this.flag ? (this.flag = true) : (this.flag = false);
    },
  },
  created() {
    
  }
};
</script>


<style scoped>
.el-menu-vertical-demo:not(.el-menu--collapse) {
  width: 200px;
  min-height: 500px;
}
</style>