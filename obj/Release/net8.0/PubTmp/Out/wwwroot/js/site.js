document.addEventListener('DOMContentLoaded', function () {
 const side=document.getElementById('sidebar'), toggle=document.getElementById('toggle'), overlay=document.getElementById('sidebarOverlay');
 toggle?.addEventListener('click',()=>{ if(window.innerWidth<=900){side.classList.toggle('mobile-open');overlay.classList.toggle('show');document.body.classList.toggle('no-scroll',side.classList.contains('mobile-open'));}else{side.classList.toggle('collapsed');document.body.classList.toggle('sidebar-collapsed');}});
 overlay?.addEventListener('click',closeMobile);
 window.addEventListener('resize',()=>{if(window.innerWidth>900){side.classList.remove('mobile-open');overlay.classList.remove('show');document.body.classList.remove('no-scroll');}});
 document.querySelectorAll('.table-filter').forEach(x=>{x.addEventListener('input',runTableFilter);x.addEventListener('change',runTableFilter);});
 document.querySelectorAll('[data-reset-table]').forEach(b=>b.addEventListener('click',()=>resetTable(b.dataset.resetTable)));
 const gs=document.getElementById('globalSearch');gs?.addEventListener('input',()=>{const q=gs.value.toLowerCase().trim();document.querySelectorAll('table tbody tr').forEach(r=>r.style.display=(!q||r.innerText.toLowerCase().includes(q))?'':'none');});
});
function closeMobile(){const s=document.getElementById('sidebar');s?.classList.remove('mobile-open');document.getElementById('sidebarOverlay')?.classList.remove('show');document.body.classList.remove('no-scroll');}
function getTable(control){const selector=control.dataset.target;if(selector){const t=document.querySelector(selector);if(t)return t;}return control.closest('.filter-panel')?.nextElementSibling?.querySelector('table') || control.closest('.tablebox,.module-card')?.querySelector('table') || document.querySelector('table');}
function runTableFilter(){const panel=this.closest('.filter-panel');const table=getTable(this);if(!table)return;const controls=[...panel.querySelectorAll('.table-filter')];table.querySelectorAll('tbody tr').forEach(row=>{const text=row.innerText.toLowerCase();const ok=controls.every(c=>!c.value || text.includes(c.value.toLowerCase()));row.style.display=ok?'':'none';});}
function resetTable(selector){const table=selector?document.querySelector(selector):null;if(table)table.querySelectorAll('tbody tr').forEach(r=>r.style.display='');const panel=table?.previousElementSibling;panel?.querySelectorAll('.table-filter').forEach(x=>x.value='');}
function resetFilters(){document.querySelectorAll('.table-filter').forEach(x=>x.value='');document.querySelectorAll('table tbody tr').forEach(x=>x.style.display='');}
function showToast(msg){let t=document.querySelector('.erp-toast');if(!t){t=document.createElement('div');t.className='erp-toast';document.body.appendChild(t)}t.textContent=msg;t.classList.add('show');setTimeout(()=>t.classList.remove('show'),1800)}
function toast(msg){showToast(msg)}