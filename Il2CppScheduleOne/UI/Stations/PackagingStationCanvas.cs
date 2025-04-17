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
	// Token: 0x02000681 RID: 1665
	public class PackagingStationCanvas : Singleton<PackagingStationCanvas>
	{
		// Token: 0x06009536 RID: 38198 RVA: 0x002646B8 File Offset: 0x002628B8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationCanvas()
		{
			Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "PackagingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr);
			PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<PackagingStation>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowHintOnOpen");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowShiftClickHint");
			PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "CurrentMode");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionWarningColor");
			PackagingStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "Canvas");
			PackagingStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "Container");
			PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "PackagingSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionLabel");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionShadow");
			PackagingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "BeginButton");
			PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ModeAnimation");
			PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ButtonLabel");
			PackagingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681750);
			PackagingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681751);
			PackagingStationCanvas.NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681752);
			PackagingStationCanvas.NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681753);
			PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681754);
			PackagingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681755);
			PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681756);
			PackagingStationCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681757);
			PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681758);
			PackagingStationCanvas.NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681759);
			PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681760);
			PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681761);
			PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681762);
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x06009537 RID: 38199 RVA: 0x0026492C File Offset: 0x00262B2C
		// (set) Token: 0x06009538 RID: 38200 RVA: 0x00264968 File Offset: 0x00262B68
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x06009539 RID: 38201 RVA: 0x002649A8 File Offset: 0x00262BA8
		// (set) Token: 0x0600953A RID: 38202 RVA: 0x002649E8 File Offset: 0x00262BE8
		public unsafe PackagingStation PackagingStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x00264A2C File Offset: 0x00262C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268205, XrefRangeEnd = 268216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x00264A68 File Offset: 0x00262C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268216, XrefRangeEnd = 268220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00264AA4 File Offset: 0x00262CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268220, XrefRangeEnd = 268255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x00264AE0 File Offset: 0x00262CE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 268346, RefRangeEnd = 268350, XrefRangeStart = 268255, XrefRangeEnd = 268346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(PackagingStation station, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x00264B40 File Offset: 0x00262D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268367, RefRangeEnd = 268368, XrefRangeStart = 268350, XrefRangeEnd = 268367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x00264B74 File Offset: 0x00262D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268368, XrefRangeEnd = 268391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlotPositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x00264BA8 File Offset: 0x00262DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268391, XrefRangeEnd = 268392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009542 RID: 38210 RVA: 0x00264BDC File Offset: 0x00262DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268438, RefRangeEnd = 268439, XrefRangeStart = 268392, XrefRangeEnd = 268438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(PackagingStation.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009543 RID: 38211 RVA: 0x00264C1C File Offset: 0x00262E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268439, XrefRangeEnd = 268442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x00048875 File Offset: 0x00046A75
		public PackagingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x06009545 RID: 38213 RVA: 0x00264C58 File Offset: 0x00262E58
		// (set) Token: 0x06009546 RID: 38214 RVA: 0x0004887E File Offset: 0x00046A7E
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x06009547 RID: 38215 RVA: 0x00264C80 File Offset: 0x00262E80
		// (set) Token: 0x06009548 RID: 38216 RVA: 0x00048899 File Offset: 0x00046A99
		public unsafe PackagingStation _PackagingStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x06009549 RID: 38217 RVA: 0x00264CB0 File Offset: 0x00262EB0
		// (set) Token: 0x0600954A RID: 38218 RVA: 0x000488B8 File Offset: 0x00046AB8
		public unsafe bool ShowHintOnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen)) = value;
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600954B RID: 38219 RVA: 0x00264CD8 File Offset: 0x00262ED8
		// (set) Token: 0x0600954C RID: 38220 RVA: 0x000488D3 File Offset: 0x00046AD3
		public unsafe bool ShowShiftClickHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint)) = value;
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600954D RID: 38221 RVA: 0x00264D00 File Offset: 0x00262F00
		// (set) Token: 0x0600954E RID: 38222 RVA: 0x000488EE File Offset: 0x00046AEE
		public unsafe PackagingStation.EMode CurrentMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode)) = value;
			}
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600954F RID: 38223 RVA: 0x00264D28 File Offset: 0x00262F28
		// (set) Token: 0x06009550 RID: 38224 RVA: 0x00048909 File Offset: 0x00046B09
		public unsafe Color InstructionWarningColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor)) = value;
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x06009551 RID: 38225 RVA: 0x00264D50 File Offset: 0x00262F50
		// (set) Token: 0x06009552 RID: 38226 RVA: 0x00048924 File Offset: 0x00046B24
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x06009553 RID: 38227 RVA: 0x00264D80 File Offset: 0x00262F80
		// (set) Token: 0x06009554 RID: 38228 RVA: 0x00048943 File Offset: 0x00046B43
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x00264DB0 File Offset: 0x00262FB0
		// (set) Token: 0x06009556 RID: 38230 RVA: 0x00048962 File Offset: 0x00046B62
		public unsafe ItemSlotUI PackagingSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x00264DE0 File Offset: 0x00262FE0
		// (set) Token: 0x06009558 RID: 38232 RVA: 0x00048981 File Offset: 0x00046B81
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x00264E10 File Offset: 0x00263010
		// (set) Token: 0x0600955A RID: 38234 RVA: 0x000489A0 File Offset: 0x00046BA0
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600955B RID: 38235 RVA: 0x00264E40 File Offset: 0x00263040
		// (set) Token: 0x0600955C RID: 38236 RVA: 0x000489BF File Offset: 0x00046BBF
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x00264E70 File Offset: 0x00263070
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x000489DE File Offset: 0x00046BDE
		public unsafe Image InstructionShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x00264EA0 File Offset: 0x002630A0
		// (set) Token: 0x06009560 RID: 38240 RVA: 0x000489FD File Offset: 0x00046BFD
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x00264ED0 File Offset: 0x002630D0
		// (set) Token: 0x06009562 RID: 38242 RVA: 0x00048A1C File Offset: 0x00046C1C
		public unsafe Animation ModeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x00264F00 File Offset: 0x00263100
		// (set) Token: 0x06009564 RID: 38244 RVA: 0x00048A3B File Offset: 0x00046C3B
		public unsafe TextMeshProUGUI ButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064A2 RID: 25762
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040064A3 RID: 25763
		private static readonly IntPtr NativeFieldInfoPtr__PackagingStation_k__BackingField;

		// Token: 0x040064A4 RID: 25764
		private static readonly IntPtr NativeFieldInfoPtr_ShowHintOnOpen;

		// Token: 0x040064A5 RID: 25765
		private static readonly IntPtr NativeFieldInfoPtr_ShowShiftClickHint;

		// Token: 0x040064A6 RID: 25766
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMode;

		// Token: 0x040064A7 RID: 25767
		private static readonly IntPtr NativeFieldInfoPtr_InstructionWarningColor;

		// Token: 0x040064A8 RID: 25768
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040064A9 RID: 25769
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040064AA RID: 25770
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlotUI;

		// Token: 0x040064AB RID: 25771
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x040064AC RID: 25772
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040064AD RID: 25773
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040064AE RID: 25774
		private static readonly IntPtr NativeFieldInfoPtr_InstructionShadow;

		// Token: 0x040064AF RID: 25775
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x040064B0 RID: 25776
		private static readonly IntPtr NativeFieldInfoPtr_ModeAnimation;

		// Token: 0x040064B1 RID: 25777
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLabel;

		// Token: 0x040064B2 RID: 25778
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040064B3 RID: 25779
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040064B4 RID: 25780
		private static readonly IntPtr NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0;

		// Token: 0x040064B5 RID: 25781
		private static readonly IntPtr NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x040064B6 RID: 25782
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040064B7 RID: 25783
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040064B8 RID: 25784
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040064B9 RID: 25785
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0;

		// Token: 0x040064BA RID: 25786
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x040064BB RID: 25787
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0;

		// Token: 0x040064BC RID: 25788
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMode_Public_Void_0;

		// Token: 0x040064BD RID: 25789
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x040064BE RID: 25790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
