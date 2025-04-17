using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067A RID: 1658
	public class BrickPressCanvas : Singleton<BrickPressCanvas>
	{
		// Token: 0x06009404 RID: 37892 RVA: 0x00260BF8 File Offset: 0x0025EDF8
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressCanvas()
		{
			Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "BrickPressCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr);
			BrickPressCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "<Press>k__BackingField");
			BrickPressCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "Canvas");
			BrickPressCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "Container");
			BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "ProductSlotUIs");
			BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "OutputSlotUI");
			BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "InstructionLabel");
			BrickPressCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "BeginButton");
			BrickPressCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681638);
			BrickPressCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681639);
			BrickPressCanvas.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681640);
			BrickPressCanvas.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681641);
			BrickPressCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681642);
			BrickPressCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681643);
			BrickPressCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681644);
			BrickPressCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_BrickPress_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681645);
			BrickPressCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681646);
			BrickPressCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100681647);
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x06009405 RID: 37893 RVA: 0x00260D90 File Offset: 0x0025EF90
		// (set) Token: 0x06009406 RID: 37894 RVA: 0x00260DCC File Offset: 0x0025EFCC
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x06009407 RID: 37895 RVA: 0x00260E0C File Offset: 0x0025F00C
		// (set) Token: 0x06009408 RID: 37896 RVA: 0x00260E4C File Offset: 0x0025F04C
		public unsafe BrickPress Press
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00260E90 File Offset: 0x0025F090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266177, XrefRangeEnd = 266188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00260ECC File Offset: 0x0025F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266188, XrefRangeEnd = 266192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00260F08 File Offset: 0x0025F108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266192, XrefRangeEnd = 266209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x00260F44 File Offset: 0x0025F144
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 266289, RefRangeEnd = 266295, XrefRangeStart = 266209, XrefRangeEnd = 266289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(BrickPress press, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_BrickPress_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00260FA4 File Offset: 0x0025F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266295, XrefRangeEnd = 266306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x00260FD8 File Offset: 0x0025F1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266306, XrefRangeEnd = 266309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00047CD4 File Offset: 0x00045ED4
		public BrickPressCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x06009410 RID: 37904 RVA: 0x00261014 File Offset: 0x0025F214
		// (set) Token: 0x06009411 RID: 37905 RVA: 0x00047CDD File Offset: 0x00045EDD
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x06009412 RID: 37906 RVA: 0x0026103C File Offset: 0x0025F23C
		// (set) Token: 0x06009413 RID: 37907 RVA: 0x00047CF8 File Offset: 0x00045EF8
		public unsafe BrickPress _Press_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x06009414 RID: 37908 RVA: 0x0026106C File Offset: 0x0025F26C
		// (set) Token: 0x06009415 RID: 37909 RVA: 0x00047D17 File Offset: 0x00045F17
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x06009416 RID: 37910 RVA: 0x0026109C File Offset: 0x0025F29C
		// (set) Token: 0x06009417 RID: 37911 RVA: 0x00047D36 File Offset: 0x00045F36
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x002610CC File Offset: 0x0025F2CC
		// (set) Token: 0x06009419 RID: 37913 RVA: 0x00047D55 File Offset: 0x00045F55
		public unsafe Il2CppReferenceArray<ItemSlotUI> ProductSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x002610FC File Offset: 0x0025F2FC
		// (set) Token: 0x0600941B RID: 37915 RVA: 0x00047D74 File Offset: 0x00045F74
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600941C RID: 37916 RVA: 0x0026112C File Offset: 0x0025F32C
		// (set) Token: 0x0600941D RID: 37917 RVA: 0x00047D93 File Offset: 0x00045F93
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600941E RID: 37918 RVA: 0x0026115C File Offset: 0x0025F35C
		// (set) Token: 0x0600941F RID: 37919 RVA: 0x00047DB2 File Offset: 0x00045FB2
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063DE RID: 25566
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040063DF RID: 25567
		private static readonly IntPtr NativeFieldInfoPtr__Press_k__BackingField;

		// Token: 0x040063E0 RID: 25568
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040063E1 RID: 25569
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040063E2 RID: 25570
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUIs;

		// Token: 0x040063E3 RID: 25571
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040063E4 RID: 25572
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040063E5 RID: 25573
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x040063E6 RID: 25574
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040063E7 RID: 25575
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040063E8 RID: 25576
		private static readonly IntPtr NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0;

		// Token: 0x040063E9 RID: 25577
		private static readonly IntPtr NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0;

		// Token: 0x040063EA RID: 25578
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063EB RID: 25579
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040063EC RID: 25580
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040063ED RID: 25581
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_BrickPress_Boolean_Boolean_0;

		// Token: 0x040063EE RID: 25582
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x040063EF RID: 25583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
