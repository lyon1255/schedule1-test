using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations.Drying_rack;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067E RID: 1662
	public class DryingRackCanvas : Singleton<DryingRackCanvas>
	{
		// Token: 0x06009497 RID: 38039 RVA: 0x0026278C File Offset: 0x0026098C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackCanvas()
		{
			Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "DryingRackCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr);
			DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<Rack>k__BackingField");
			DryingRackCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "Canvas");
			DryingRackCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "Container");
			DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InputSlotUI");
			DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "OutputSlotUI");
			DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InstructionLabel");
			DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "CapacityLabel");
			DryingRackCanvas.NativeFieldInfoPtr_InsertButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InsertButton");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorContainer");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorAlignments");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorPrefab");
			DryingRackCanvas.NativeFieldInfoPtr_operationUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "operationUIs");
			DryingRackCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681693);
			DryingRackCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681694);
			DryingRackCanvas.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681695);
			DryingRackCanvas.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681696);
			DryingRackCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681697);
			DryingRackCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681698);
			DryingRackCanvas.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681699);
			DryingRackCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681700);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681701);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681702);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681703);
			DryingRackCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681704);
			DryingRackCanvas.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681705);
			DryingRackCanvas.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681706);
			DryingRackCanvas.NativeMethodInfoPtr_Insert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681707);
			DryingRackCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681708);
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x06009498 RID: 38040 RVA: 0x00262A00 File Offset: 0x00260C00
		// (set) Token: 0x06009499 RID: 38041 RVA: 0x00262A3C File Offset: 0x00260C3C
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600949A RID: 38042 RVA: 0x00262A7C File Offset: 0x00260C7C
		// (set) Token: 0x0600949B RID: 38043 RVA: 0x00262ABC File Offset: 0x00260CBC
		public unsafe DryingRack Rack
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x00262B00 File Offset: 0x00260D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267051, XrefRangeEnd = 267054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00262B3C File Offset: 0x00260D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267054, XrefRangeEnd = 267076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x00262B78 File Offset: 0x00260D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267076, XrefRangeEnd = 267077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x00262BAC File Offset: 0x00260DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267077, XrefRangeEnd = 267078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x00262BE8 File Offset: 0x00260DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267088, RefRangeEnd = 267090, XrefRangeStart = 267078, XrefRangeEnd = 267088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00262C1C File Offset: 0x00260E1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 267119, RefRangeEnd = 267123, XrefRangeStart = 267090, XrefRangeEnd = 267119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDryingOperations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x00262C50 File Offset: 0x00260E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267123, XrefRangeEnd = 267141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x00262C84 File Offset: 0x00260E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267324, RefRangeEnd = 267327, XrefRangeStart = 267141, XrefRangeEnd = 267324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(DryingRack rack, bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x00262CD4 File Offset: 0x00260ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267327, XrefRangeEnd = 267346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x00262D18 File Offset: 0x00260F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267346, XrefRangeEnd = 267371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x00262D5C File Offset: 0x00260F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267371, XrefRangeEnd = 267373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_Insert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x00262D90 File Offset: 0x00260F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267373, XrefRangeEnd = 267383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00048277 File Offset: 0x00046477
		public DryingRackCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x060094A9 RID: 38057 RVA: 0x00262DCC File Offset: 0x00260FCC
		// (set) Token: 0x060094AA RID: 38058 RVA: 0x00048280 File Offset: 0x00046480
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x060094AB RID: 38059 RVA: 0x00262DF4 File Offset: 0x00260FF4
		// (set) Token: 0x060094AC RID: 38060 RVA: 0x0004829B File Offset: 0x0004649B
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x060094AD RID: 38061 RVA: 0x00262E24 File Offset: 0x00261024
		// (set) Token: 0x060094AE RID: 38062 RVA: 0x000482BA File Offset: 0x000464BA
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x060094AF RID: 38063 RVA: 0x00262E54 File Offset: 0x00261054
		// (set) Token: 0x060094B0 RID: 38064 RVA: 0x000482D9 File Offset: 0x000464D9
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x060094B1 RID: 38065 RVA: 0x00262E84 File Offset: 0x00261084
		// (set) Token: 0x060094B2 RID: 38066 RVA: 0x000482F8 File Offset: 0x000464F8
		public unsafe ItemSlotUI InputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x060094B3 RID: 38067 RVA: 0x00262EB4 File Offset: 0x002610B4
		// (set) Token: 0x060094B4 RID: 38068 RVA: 0x00048317 File Offset: 0x00046517
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x060094B5 RID: 38069 RVA: 0x00262EE4 File Offset: 0x002610E4
		// (set) Token: 0x060094B6 RID: 38070 RVA: 0x00048336 File Offset: 0x00046536
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x060094B7 RID: 38071 RVA: 0x00262F14 File Offset: 0x00261114
		// (set) Token: 0x060094B8 RID: 38072 RVA: 0x00048355 File Offset: 0x00046555
		public unsafe TextMeshProUGUI CapacityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x060094B9 RID: 38073 RVA: 0x00262F44 File Offset: 0x00261144
		// (set) Token: 0x060094BA RID: 38074 RVA: 0x00048374 File Offset: 0x00046574
		public unsafe Button InsertButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InsertButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InsertButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x060094BB RID: 38075 RVA: 0x00262F74 File Offset: 0x00261174
		// (set) Token: 0x060094BC RID: 38076 RVA: 0x00048393 File Offset: 0x00046593
		public unsafe RectTransform IndicatorContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x060094BD RID: 38077 RVA: 0x00262FA4 File Offset: 0x002611A4
		// (set) Token: 0x060094BE RID: 38078 RVA: 0x000483B2 File Offset: 0x000465B2
		public unsafe Il2CppReferenceArray<RectTransform> IndicatorAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x060094BF RID: 38079 RVA: 0x00262FD4 File Offset: 0x002611D4
		// (set) Token: 0x060094C0 RID: 38080 RVA: 0x000483D1 File Offset: 0x000465D1
		public unsafe DryingOperationUI IndicatorPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperationUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x060094C1 RID: 38081 RVA: 0x00263004 File Offset: 0x00261204
		// (set) Token: 0x060094C2 RID: 38082 RVA: 0x000483F0 File Offset: 0x000465F0
		public unsafe List<DryingOperationUI> operationUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_operationUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingOperationUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_operationUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400643A RID: 25658
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400643B RID: 25659
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x0400643C RID: 25660
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400643D RID: 25661
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400643E RID: 25662
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotUI;

		// Token: 0x0400643F RID: 25663
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04006440 RID: 25664
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006441 RID: 25665
		private static readonly IntPtr NativeFieldInfoPtr_CapacityLabel;

		// Token: 0x04006442 RID: 25666
		private static readonly IntPtr NativeFieldInfoPtr_InsertButton;

		// Token: 0x04006443 RID: 25667
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorContainer;

		// Token: 0x04006444 RID: 25668
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorAlignments;

		// Token: 0x04006445 RID: 25669
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorPrefab;

		// Token: 0x04006446 RID: 25670
		private static readonly IntPtr NativeFieldInfoPtr_operationUIs;

		// Token: 0x04006447 RID: 25671
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006448 RID: 25672
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006449 RID: 25673
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x0400644A RID: 25674
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x0400644B RID: 25675
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400644C RID: 25676
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400644D RID: 25677
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400644E RID: 25678
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400644F RID: 25679
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006450 RID: 25680
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0;

		// Token: 0x04006451 RID: 25681
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuantities_Private_Void_0;

		// Token: 0x04006452 RID: 25682
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0;

		// Token: 0x04006453 RID: 25683
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x04006454 RID: 25684
		private static readonly IntPtr NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x04006455 RID: 25685
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_0;

		// Token: 0x04006456 RID: 25686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5D RID: 2909
		[ObfuscatedName("ScheduleOne.UI.Stations.DryingRackCanvas+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA31 RID: 55857 RVA: 0x0033B9E8 File Offset: 0x00339BE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr);
				DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, "operation");
				DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100681709);
				DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100681710);
			}

			// Token: 0x0600DA32 RID: 55858 RVA: 0x0033BA50 File Offset: 0x00339C50
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA33 RID: 55859 RVA: 0x0033BA8C File Offset: 0x00339C8C
			[CallerCount(0)]
			public unsafe bool _DestroyOperationUI_b__0(DryingOperationUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA34 RID: 55860 RVA: 0x0006A3FC File Offset: 0x000685FC
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B0 RID: 17328
			// (get) Token: 0x0600DA35 RID: 55861 RVA: 0x0033BADC File Offset: 0x00339CDC
			// (set) Token: 0x0600DA36 RID: 55862 RVA: 0x0006A405 File Offset: 0x00068605
			public unsafe DryingOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400927D RID: 37501
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400927E RID: 37502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400927F RID: 37503
			private static readonly IntPtr NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0;
		}
	}
}
