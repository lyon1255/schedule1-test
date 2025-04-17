using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063E RID: 1598
	public class GenericUIScreen : MonoBehaviour
	{
		// Token: 0x06008D41 RID: 36161 RVA: 0x0024D144 File Offset: 0x0024B344
		// Note: this type is marked as 'beforefieldinit'.
		static GenericUIScreen()
		{
			Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericUIScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr);
			GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			GenericUIScreen.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "Name");
			GenericUIScreen.NativeFieldInfoPtr_UseExitActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "UseExitActions");
			GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ExitActionPriority");
			GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "CanExitWithRightClick");
			GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableControlsOnClose");
			GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableInventoryOnClose");
			GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableEquippingOnClose");
			GenericUIScreen.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "onOpen");
			GenericUIScreen.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "onClose");
			GenericUIScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680854);
			GenericUIScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680855);
			GenericUIScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680856);
			GenericUIScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680857);
			GenericUIScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680858);
			GenericUIScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680859);
			GenericUIScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680860);
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x06008D42 RID: 36162 RVA: 0x0024D2C8 File Offset: 0x0024B4C8
		// (set) Token: 0x06008D43 RID: 36163 RVA: 0x0024D304 File Offset: 0x0024B504
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x0024D344 File Offset: 0x0024B544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257665, XrefRangeEnd = 257675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x0024D378 File Offset: 0x0024B578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257698, RefRangeEnd = 257700, XrefRangeStart = 257675, XrefRangeEnd = 257698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0024D3AC File Offset: 0x0024B5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257727, RefRangeEnd = 257728, XrefRangeStart = 257700, XrefRangeEnd = 257727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x0024D3E0 File Offset: 0x0024B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257728, XrefRangeEnd = 257729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x0024D424 File Offset: 0x0024B624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257729, XrefRangeEnd = 257730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericUIScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x00043C48 File Offset: 0x00041E48
		public GenericUIScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06008D4A RID: 36170 RVA: 0x0024D460 File Offset: 0x0024B660
		// (set) Token: 0x06008D4B RID: 36171 RVA: 0x00043C51 File Offset: 0x00041E51
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x06008D4C RID: 36172 RVA: 0x0024D488 File Offset: 0x0024B688
		// (set) Token: 0x06008D4D RID: 36173 RVA: 0x00043C6C File Offset: 0x00041E6C
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x06008D4E RID: 36174 RVA: 0x0024D4B0 File Offset: 0x0024B6B0
		// (set) Token: 0x06008D4F RID: 36175 RVA: 0x00043C8B File Offset: 0x00041E8B
		public unsafe bool UseExitActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_UseExitActions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_UseExitActions)) = value;
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x06008D50 RID: 36176 RVA: 0x0024D4D8 File Offset: 0x0024B6D8
		// (set) Token: 0x06008D51 RID: 36177 RVA: 0x00043CA6 File Offset: 0x00041EA6
		public unsafe int ExitActionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority)) = value;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x06008D52 RID: 36178 RVA: 0x0024D500 File Offset: 0x0024B700
		// (set) Token: 0x06008D53 RID: 36179 RVA: 0x00043CC1 File Offset: 0x00041EC1
		public unsafe bool CanExitWithRightClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick)) = value;
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x06008D54 RID: 36180 RVA: 0x0024D528 File Offset: 0x0024B728
		// (set) Token: 0x06008D55 RID: 36181 RVA: 0x00043CDC File Offset: 0x00041EDC
		public unsafe bool ReenableControlsOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose)) = value;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x06008D56 RID: 36182 RVA: 0x0024D550 File Offset: 0x0024B750
		// (set) Token: 0x06008D57 RID: 36183 RVA: 0x00043CF7 File Offset: 0x00041EF7
		public unsafe bool ReenableInventoryOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose)) = value;
			}
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x06008D58 RID: 36184 RVA: 0x0024D578 File Offset: 0x0024B778
		// (set) Token: 0x06008D59 RID: 36185 RVA: 0x00043D12 File Offset: 0x00041F12
		public unsafe bool ReenableEquippingOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose)) = value;
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x06008D5A RID: 36186 RVA: 0x0024D5A0 File Offset: 0x0024B7A0
		// (set) Token: 0x06008D5B RID: 36187 RVA: 0x00043D2D File Offset: 0x00041F2D
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x06008D5C RID: 36188 RVA: 0x0024D5D0 File Offset: 0x0024B7D0
		// (set) Token: 0x06008D5D RID: 36189 RVA: 0x00043D4C File Offset: 0x00041F4C
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005FB4 RID: 24500
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005FB5 RID: 24501
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005FB6 RID: 24502
		private static readonly IntPtr NativeFieldInfoPtr_UseExitActions;

		// Token: 0x04005FB7 RID: 24503
		private static readonly IntPtr NativeFieldInfoPtr_ExitActionPriority;

		// Token: 0x04005FB8 RID: 24504
		private static readonly IntPtr NativeFieldInfoPtr_CanExitWithRightClick;

		// Token: 0x04005FB9 RID: 24505
		private static readonly IntPtr NativeFieldInfoPtr_ReenableControlsOnClose;

		// Token: 0x04005FBA RID: 24506
		private static readonly IntPtr NativeFieldInfoPtr_ReenableInventoryOnClose;

		// Token: 0x04005FBB RID: 24507
		private static readonly IntPtr NativeFieldInfoPtr_ReenableEquippingOnClose;

		// Token: 0x04005FBC RID: 24508
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04005FBD RID: 24509
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04005FBE RID: 24510
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005FBF RID: 24511
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005FC0 RID: 24512
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005FC1 RID: 24513
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005FC2 RID: 24514
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005FC3 RID: 24515
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005FC4 RID: 24516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
