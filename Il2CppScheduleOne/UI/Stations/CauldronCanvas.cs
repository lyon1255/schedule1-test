using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067B RID: 1659
	public class CauldronCanvas : Singleton<CauldronCanvas>
	{
		// Token: 0x06009420 RID: 37920 RVA: 0x0026118C File Offset: 0x0025F38C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronCanvas()
		{
			Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "CauldronCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr);
			CauldronCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			CauldronCanvas.NativeFieldInfoPtr__Cauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "<Cauldron>k__BackingField");
			CauldronCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "Canvas");
			CauldronCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "Container");
			CauldronCanvas.NativeFieldInfoPtr_IngredientSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "IngredientSlotUIs");
			CauldronCanvas.NativeFieldInfoPtr_LiquidSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "LiquidSlotUI");
			CauldronCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "OutputSlotUI");
			CauldronCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "InstructionLabel");
			CauldronCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "BeginButton");
			CauldronCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681648);
			CauldronCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681649);
			CauldronCanvas.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681650);
			CauldronCanvas.NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681651);
			CauldronCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681652);
			CauldronCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681653);
			CauldronCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681654);
			CauldronCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Cauldron_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681655);
			CauldronCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681656);
			CauldronCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100681657);
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x06009421 RID: 37921 RVA: 0x00261338 File Offset: 0x0025F538
		// (set) Token: 0x06009422 RID: 37922 RVA: 0x00261374 File Offset: 0x0025F574
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x06009423 RID: 37923 RVA: 0x002613B4 File Offset: 0x0025F5B4
		// (set) Token: 0x06009424 RID: 37924 RVA: 0x002613F4 File Offset: 0x0025F5F4
		public unsafe Cauldron Cauldron
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00261438 File Offset: 0x0025F638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266309, XrefRangeEnd = 266320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00261474 File Offset: 0x0025F674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266320, XrefRangeEnd = 266324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x002614B0 File Offset: 0x0025F6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266324, XrefRangeEnd = 266353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x002614EC File Offset: 0x0025F6EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 266450, RefRangeEnd = 266455, XrefRangeStart = 266353, XrefRangeEnd = 266450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(Cauldron cauldron, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Cauldron_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x0026154C File Offset: 0x0025F74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266455, XrefRangeEnd = 266465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x00261580 File Offset: 0x0025F780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266465, XrefRangeEnd = 266468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x00047DD1 File Offset: 0x00045FD1
		public CauldronCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x002615BC File Offset: 0x0025F7BC
		// (set) Token: 0x0600942D RID: 37933 RVA: 0x00047DDA File Offset: 0x00045FDA
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x002615E4 File Offset: 0x0025F7E4
		// (set) Token: 0x0600942F RID: 37935 RVA: 0x00047DF5 File Offset: 0x00045FF5
		public unsafe Cauldron _Cauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__Cauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__Cauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x06009430 RID: 37936 RVA: 0x00261614 File Offset: 0x0025F814
		// (set) Token: 0x06009431 RID: 37937 RVA: 0x00047E14 File Offset: 0x00046014
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x06009432 RID: 37938 RVA: 0x00261644 File Offset: 0x0025F844
		// (set) Token: 0x06009433 RID: 37939 RVA: 0x00047E33 File Offset: 0x00046033
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x06009434 RID: 37940 RVA: 0x00261674 File Offset: 0x0025F874
		// (set) Token: 0x06009435 RID: 37941 RVA: 0x00047E52 File Offset: 0x00046052
		public unsafe List<ItemSlotUI> IngredientSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_IngredientSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_IngredientSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x06009436 RID: 37942 RVA: 0x002616A4 File Offset: 0x0025F8A4
		// (set) Token: 0x06009437 RID: 37943 RVA: 0x00047E71 File Offset: 0x00046071
		public unsafe ItemSlotUI LiquidSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_LiquidSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_LiquidSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x002616D4 File Offset: 0x0025F8D4
		// (set) Token: 0x06009439 RID: 37945 RVA: 0x00047E90 File Offset: 0x00046090
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600943A RID: 37946 RVA: 0x00261704 File Offset: 0x0025F904
		// (set) Token: 0x0600943B RID: 37947 RVA: 0x00047EAF File Offset: 0x000460AF
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600943C RID: 37948 RVA: 0x00261734 File Offset: 0x0025F934
		// (set) Token: 0x0600943D RID: 37949 RVA: 0x00047ECE File Offset: 0x000460CE
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063F0 RID: 25584
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040063F1 RID: 25585
		private static readonly IntPtr NativeFieldInfoPtr__Cauldron_k__BackingField;

		// Token: 0x040063F2 RID: 25586
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040063F3 RID: 25587
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040063F4 RID: 25588
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUIs;

		// Token: 0x040063F5 RID: 25589
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSlotUI;

		// Token: 0x040063F6 RID: 25590
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040063F7 RID: 25591
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040063F8 RID: 25592
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x040063F9 RID: 25593
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040063FA RID: 25594
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040063FB RID: 25595
		private static readonly IntPtr NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0;

		// Token: 0x040063FC RID: 25596
		private static readonly IntPtr NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x040063FD RID: 25597
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063FE RID: 25598
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040063FF RID: 25599
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006400 RID: 25600
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Cauldron_Boolean_Boolean_0;

		// Token: 0x04006401 RID: 25601
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04006402 RID: 25602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
