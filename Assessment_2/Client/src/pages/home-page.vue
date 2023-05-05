<template>
    <DxDataGrid id="people-grid"
                :data-source="dataSource"
                :show-borders="true"
                :hover-state-enabled="true">

        <DxColumn :width="40" data-field="Id" />
        <DxColumn :width="255" data-field="Name" />
        <DxColumn :width="100" data-field="Age" />

        <DxPager :show-page-size-selector="false"
                 :allowed-page-sizes="[10]"
                 :show-navigation-buttons="true" />
    </DxDataGrid>
</template>

<script lang="ts">
    import 'devextreme/dist/css/dx.light.css';
    import 'devextreme/data/odata/store';

    import { defineComponent } from 'vue';
    import DataSource from 'devextreme/data/data_source';
        
    import {
        DxDataGrid,
        DxColumn,
        DxPager
    } from "devextreme-vue/data-grid";

    export default defineComponent({
        name: "home-page",

        components: {
            DxColumn,
            DxDataGrid,
            DxPager,
        },

        data() {
            return {
                dataSource: new DataSource({
                    store: {
                        type: 'odata',
                        url: "/PersonWebAPI",
                        key: "Id",
                    },
                }),
            }
        },

        methods: { },
    })
</script>