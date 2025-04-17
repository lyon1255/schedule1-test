using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.UI.Management;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000528 RID: 1320
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600760E RID: 30222 RVA: 0x00201FD4 File Offset: 0x002001D4
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard_Equippable()
		{
			Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr);
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Clipboard");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "LoweredPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "RaisedPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Light");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "OverrideText");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "moveRoutine");
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678175);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678176);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678177);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678178);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678179);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678180);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678181);
			ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678182);
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00202130 File Offset: 0x00200330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230313, XrefRangeEnd = 230363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00202180 File Offset: 0x00200380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230363, XrefRangeEnd = 230398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x002021BC File Offset: 0x002003BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230398, XrefRangeEnd = 230446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x002021F8 File Offset: 0x002003F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230446, XrefRangeEnd = 230464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x0020222C File Offset: 0x0020042C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230464, XrefRangeEnd = 230483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00202260 File Offset: 0x00200460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230488, RefRangeEnd = 230491, XrefRangeStart = 230483, XrefRangeEnd = 230488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideClipboardText(string overriddenText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(overriddenText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x002022A4 File Offset: 0x002004A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230496, RefRangeEnd = 230499, XrefRangeStart = 230491, XrefRangeEnd = 230496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x002022D8 File Offset: 0x002004D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00037EDB File Offset: 0x000360DB
		public ManagementClipboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x06007618 RID: 30232 RVA: 0x00202314 File Offset: 0x00200514
		// (set) Token: 0x06007619 RID: 30233 RVA: 0x00037EE4 File Offset: 0x000360E4
		public unsafe Transform Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600761A RID: 30234 RVA: 0x00202344 File Offset: 0x00200544
		// (set) Token: 0x0600761B RID: 30235 RVA: 0x00037F03 File Offset: 0x00036103
		public unsafe Transform LoweredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600761C RID: 30236 RVA: 0x00202374 File Offset: 0x00200574
		// (set) Token: 0x0600761D RID: 30237 RVA: 0x00037F22 File Offset: 0x00036122
		public unsafe Transform RaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x0600761E RID: 30238 RVA: 0x002023A4 File Offset: 0x002005A4
		// (set) Token: 0x0600761F RID: 30239 RVA: 0x00037F41 File Offset: 0x00036141
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x06007620 RID: 30240 RVA: 0x002023D4 File Offset: 0x002005D4
		// (set) Token: 0x06007621 RID: 30241 RVA: 0x00037F60 File Offset: 0x00036160
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06007622 RID: 30242 RVA: 0x00202404 File Offset: 0x00200604
		// (set) Token: 0x06007623 RID: 30243 RVA: 0x00037F7F File Offset: 0x0003617F
		public unsafe TextMeshProUGUI OverrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x06007624 RID: 30244 RVA: 0x00202434 File Offset: 0x00200634
		// (set) Token: 0x06007625 RID: 30245 RVA: 0x00037F9E File Offset: 0x0003619E
		public unsafe Coroutine moveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050AE RID: 20654
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x040050AF RID: 20655
		private static readonly IntPtr NativeFieldInfoPtr_LoweredPosition;

		// Token: 0x040050B0 RID: 20656
		private static readonly IntPtr NativeFieldInfoPtr_RaisedPosition;

		// Token: 0x040050B1 RID: 20657
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040050B2 RID: 20658
		private static readonly IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x040050B3 RID: 20659
		private static readonly IntPtr NativeFieldInfoPtr_OverrideText;

		// Token: 0x040050B4 RID: 20660
		private static readonly IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x040050B5 RID: 20661
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040050B6 RID: 20662
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040050B7 RID: 20663
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040050B8 RID: 20664
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenEnter_Private_Void_0;

		// Token: 0x040050B9 RID: 20665
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenExit_Private_Void_0;

		// Token: 0x040050BA RID: 20666
		private static readonly IntPtr NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0;

		// Token: 0x040050BB RID: 20667
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x040050BC RID: 20668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
