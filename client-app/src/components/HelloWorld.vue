<template>
  <div class="hello">
    <h1>{{ msg }}</h1>

    <ul>
      <li v-bind:key="i.id" v-for="i in items">{{ i.text }}</li>
    </ul>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

type TodoItem = {
  id: number,
  text: string,
};

type DataType = {
  items: TodoItem[],
}

export default Vue.extend({
  name: 'HelloWorld',
  props: {
    msg: String,
  },
  data(): DataType {
    return {
      items: [],
    };
  },
  async created() {
    const res = await fetch('/api/Todo');
    if (!res.ok) {
      this.items = [];
      return;
    }
    
    this.items = await res.json() as TodoItem[];
  }
});
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
