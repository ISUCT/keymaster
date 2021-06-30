import * as React from 'react';
import { getRooms } from "./TeacherService"
import { DataGrid, GridColDef, GridValueGetterParams } from '@material-ui/data-grid';

const columns: GridColDef[] = [
  { field: 'id', headerName: 'KeyID', width: 150 },
  { field: 'roomNumber', headerName: 'Room Number', width: 150 },

  {
    field: 'qrCode',
    headerName: 'QR Code',
    description: 'This column get string qrCode using Keyid + number.',
    sortable: false,
    width: 160,
    valueGetter: (params: GridValueGetterParams) =>
      `${params.getValue(params.id, 'id') || ''}${
        params.getValue(params.id, 'roomNumber') || ''
      }`,
  },
 
];

const rows = getRooms


export default function DataGridDemo() {
  return (
    <div style={{ height: 400, width: '100%' }}>
      <DataGrid rows={getRooms()} columns={columns} pageSize={5} checkboxSelection />
    </div>
  );
}
