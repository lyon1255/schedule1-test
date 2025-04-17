using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067F RID: 1663
	public class LabOvenCanvas : Singleton<LabOvenCanvas>
	{
		// Token: 0x060094C3 RID: 38083 RVA: 0x00263034 File Offset: 0x00261234
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenCanvas()
		{
			Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "LabOvenCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr);
			LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<Oven>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "Canvas");
			LabOvenCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "Container");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "OutputSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "InstructionLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ErrorLabel");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButton");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButtonLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressContainer");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientIcon");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressImg");
			LabOvenCanvas.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProductIcon");
			LabOvenCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681711);
			LabOvenCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681712);
			LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681713);
			LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681714);
			LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681715);
			LabOvenCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681716);
			LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681717);
			LabOvenCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681718);
			LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681719);
			LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681720);
			LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681721);
			LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681722);
			LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681723);
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x060094C4 RID: 38084 RVA: 0x00263280 File Offset: 0x00261480
		// (set) Token: 0x060094C5 RID: 38085 RVA: 0x002632BC File Offset: 0x002614BC
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x060094C6 RID: 38086 RVA: 0x002632FC File Offset: 0x002614FC
		// (set) Token: 0x060094C7 RID: 38087 RVA: 0x0026333C File Offset: 0x0026153C
		public unsafe LabOven Oven
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00263380 File Offset: 0x00261580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267383, XrefRangeEnd = 267394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x002633BC File Offset: 0x002615BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267394, XrefRangeEnd = 267398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x002633F8 File Offset: 0x002615F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267398, XrefRangeEnd = 267421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x00263434 File Offset: 0x00261634
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 267496, RefRangeEnd = 267503, XrefRangeStart = 267421, XrefRangeEnd = 267496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(LabOven oven, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x00263494 File Offset: 0x00261694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267529, RefRangeEnd = 267530, XrefRangeStart = 267503, XrefRangeEnd = 267529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x002634C8 File Offset: 0x002616C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267530, XrefRangeEnd = 267537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x00263504 File Offset: 0x00261704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267539, RefRangeEnd = 267541, XrefRangeStart = 267537, XrefRangeEnd = 267539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesOvenOutputHaveSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00263540 File Offset: 0x00261740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267541, XrefRangeEnd = 267545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshActiveOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x00263574 File Offset: 0x00261774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267545, XrefRangeEnd = 267548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x0004840F File Offset: 0x0004660F
		public LabOvenCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x060094D2 RID: 38098 RVA: 0x002635B0 File Offset: 0x002617B0
		// (set) Token: 0x060094D3 RID: 38099 RVA: 0x00048418 File Offset: 0x00046618
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x060094D4 RID: 38100 RVA: 0x002635D8 File Offset: 0x002617D8
		// (set) Token: 0x060094D5 RID: 38101 RVA: 0x00048433 File Offset: 0x00046633
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x060094D6 RID: 38102 RVA: 0x00263608 File Offset: 0x00261808
		// (set) Token: 0x060094D7 RID: 38103 RVA: 0x00048452 File Offset: 0x00046652
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x060094D8 RID: 38104 RVA: 0x00263638 File Offset: 0x00261838
		// (set) Token: 0x060094D9 RID: 38105 RVA: 0x00048471 File Offset: 0x00046671
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x060094DA RID: 38106 RVA: 0x00263668 File Offset: 0x00261868
		// (set) Token: 0x060094DB RID: 38107 RVA: 0x00048490 File Offset: 0x00046690
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x060094DC RID: 38108 RVA: 0x00263698 File Offset: 0x00261898
		// (set) Token: 0x060094DD RID: 38109 RVA: 0x000484AF File Offset: 0x000466AF
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x060094DE RID: 38110 RVA: 0x002636C8 File Offset: 0x002618C8
		// (set) Token: 0x060094DF RID: 38111 RVA: 0x000484CE File Offset: 0x000466CE
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x060094E0 RID: 38112 RVA: 0x002636F8 File Offset: 0x002618F8
		// (set) Token: 0x060094E1 RID: 38113 RVA: 0x000484ED File Offset: 0x000466ED
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x060094E2 RID: 38114 RVA: 0x00263728 File Offset: 0x00261928
		// (set) Token: 0x060094E3 RID: 38115 RVA: 0x0004850C File Offset: 0x0004670C
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x00263758 File Offset: 0x00261958
		// (set) Token: 0x060094E5 RID: 38117 RVA: 0x0004852B File Offset: 0x0004672B
		public unsafe TextMeshProUGUI BeginButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x060094E6 RID: 38118 RVA: 0x00263788 File Offset: 0x00261988
		// (set) Token: 0x060094E7 RID: 38119 RVA: 0x0004854A File Offset: 0x0004674A
		public unsafe RectTransform ProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x060094E8 RID: 38120 RVA: 0x002637B8 File Offset: 0x002619B8
		// (set) Token: 0x060094E9 RID: 38121 RVA: 0x00048569 File Offset: 0x00046769
		public unsafe Image IngredientIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x060094EA RID: 38122 RVA: 0x002637E8 File Offset: 0x002619E8
		// (set) Token: 0x060094EB RID: 38123 RVA: 0x00048588 File Offset: 0x00046788
		public unsafe Image ProgressImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x060094EC RID: 38124 RVA: 0x00263818 File Offset: 0x00261A18
		// (set) Token: 0x060094ED RID: 38125 RVA: 0x000485A7 File Offset: 0x000467A7
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006457 RID: 25687
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006458 RID: 25688
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04006459 RID: 25689
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400645A RID: 25690
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400645B RID: 25691
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x0400645C RID: 25692
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400645D RID: 25693
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400645E RID: 25694
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x0400645F RID: 25695
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006460 RID: 25696
		private static readonly IntPtr NativeFieldInfoPtr_BeginButtonLabel;

		// Token: 0x04006461 RID: 25697
		private static readonly IntPtr NativeFieldInfoPtr_ProgressContainer;

		// Token: 0x04006462 RID: 25698
		private static readonly IntPtr NativeFieldInfoPtr_IngredientIcon;

		// Token: 0x04006463 RID: 25699
		private static readonly IntPtr NativeFieldInfoPtr_ProgressImg;

		// Token: 0x04006464 RID: 25700
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x04006465 RID: 25701
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006466 RID: 25702
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006467 RID: 25703
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04006468 RID: 25704
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0;

		// Token: 0x04006469 RID: 25705
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400646A RID: 25706
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400646B RID: 25707
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400646C RID: 25708
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0;

		// Token: 0x0400646D RID: 25709
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400646E RID: 25710
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Public_Boolean_0;

		// Token: 0x0400646F RID: 25711
		private static readonly IntPtr NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0;

		// Token: 0x04006470 RID: 25712
		private static readonly IntPtr NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0;

		// Token: 0x04006471 RID: 25713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
