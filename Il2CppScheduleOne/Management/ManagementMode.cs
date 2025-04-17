using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039E RID: 926
	public class ManagementMode : Singleton<ManagementMode>
	{
		// Token: 0x06004889 RID: 18569 RVA: 0x00162E48 File Offset: 0x00161048
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementMode()
		{
			Il2CppClassPointerStore<ManagementMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr);
			ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "ManagementModeInputPrompt");
			ManagementMode.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "Canvas");
			ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "OnEnterManagementMode");
			ManagementMode.NativeFieldInfoPtr_onExitManagementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "onExitManagementMode");
			ManagementMode.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672291);
			ManagementMode.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672292);
			ManagementMode.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672293);
			ManagementMode.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672294);
			ManagementMode.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672295);
			ManagementMode.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672296);
			ManagementMode.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672297);
			ManagementMode.NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672298);
			ManagementMode.NativeMethodInfoPtr_ExitManagementMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672299);
			ManagementMode.NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672300);
			ManagementMode.NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672301);
			ManagementMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672302);
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x00162FCC File Offset: 0x001611CC
		// (set) Token: 0x0600488B RID: 18571 RVA: 0x0016300C File Offset: 0x0016120C
		public unsafe Property CurrentProperty
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x00163050 File Offset: 0x00161250
		public unsafe bool isActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162349, XrefRangeEnd = 162353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x0016308C File Offset: 0x0016128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162353, XrefRangeEnd = 162368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementMode.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x001630C8 File Offset: 0x001612C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162368, XrefRangeEnd = 162382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x001630FC File Offset: 0x001612FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162448, RefRangeEnd = 162449, XrefRangeStart = 162382, XrefRangeEnd = 162448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00163130 File Offset: 0x00161330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162449, XrefRangeEnd = 162454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00163174 File Offset: 0x00161374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162454, XrefRangeEnd = 162468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterManagementMode(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x001631B8 File Offset: 0x001613B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162482, RefRangeEnd = 162484, XrefRangeStart = 162468, XrefRangeEnd = 162482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitManagementMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_ExitManagementMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x001631EC File Offset: 0x001613EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162484, XrefRangeEnd = 162497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanEnterManagementMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x0016321C File Offset: 0x0016141C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanExitManagementMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x0016324C File Offset: 0x0016144C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162497, XrefRangeEnd = 162500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementMode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00022F58 File Offset: 0x00021158
		public ManagementMode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004897 RID: 18583 RVA: 0x00163288 File Offset: 0x00161488
		// (set) Token: 0x06004898 RID: 18584 RVA: 0x00022F61 File Offset: 0x00021161
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x001632B8 File Offset: 0x001614B8
		// (set) Token: 0x0600489A RID: 18586 RVA: 0x00022F80 File Offset: 0x00021180
		public unsafe InputPrompt ManagementModeInputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x001632E8 File Offset: 0x001614E8
		// (set) Token: 0x0600489C RID: 18588 RVA: 0x00022F9F File Offset: 0x0002119F
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x00163318 File Offset: 0x00161518
		// (set) Token: 0x0600489E RID: 18590 RVA: 0x00022FBE File Offset: 0x000211BE
		public unsafe UnityEvent OnEnterManagementMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x00163348 File Offset: 0x00161548
		// (set) Token: 0x060048A0 RID: 18592 RVA: 0x00022FDD File Offset: 0x000211DD
		public unsafe UnityEvent onExitManagementMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_onExitManagementMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_onExitManagementMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeFieldInfoPtr_ManagementModeInputPrompt;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeFieldInfoPtr_OnEnterManagementMode;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeFieldInfoPtr_onExitManagementMode;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr_ExitManagementMode_Public_Void_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
