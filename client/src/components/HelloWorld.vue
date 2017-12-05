<template>
  <div class="hello">
    <h1>Enter a name and press the 'Generate' button or leave blank and press 'Generate'</h1>
    <div>
      <input type="text" v-model="name">
      <button @click="generate">Generate</button>
    </div>
    <h2 class="message" v-if="msg">{{ msg }}</h2>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'HelloWorld',
  data() {
    return {
      msg: '',
      name: '',
    };
  },
  methods: {
    async generate() {
      let result;
      if (this.name) {
        result = await axios.get(`http://localhost:5000/api/message/${this.name}`);
      } else {
        result = await axios.get('http://localhost:5000/api/message');
      }
      this.msg = result.data;
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
