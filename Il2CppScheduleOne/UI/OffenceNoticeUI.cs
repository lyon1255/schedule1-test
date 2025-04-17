using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000659 RID: 1625
	public class OffenceNoticeUI : Singleton<OffenceNoticeUI>
	{
		// Token: 0x06009106 RID: 37126 RVA: 0x00257F08 File Offset: 0x00256108
		// Note: this type is marked as 'beforefieldinit'.
		static OffenceNoticeUI()
		{
			Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OffenceNoticeUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr);
			OffenceNoticeUI.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "container");
			OffenceNoticeUI.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "charges");
			OffenceNoticeUI.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "penalties");
			OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681261);
			OffenceNoticeUI.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681262);
			OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681263);
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x00257FB0 File Offset: 0x002561B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262187, XrefRangeEnd = 262238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOffenceNotice(Offense offence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00257FF4 File Offset: 0x002561F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262238, XrefRangeEnd = 262267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x00258028 File Offset: 0x00256228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262267, XrefRangeEnd = 262282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffenceNoticeUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x0004614B File Offset: 0x0004434B
		public OffenceNoticeUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0600910B RID: 37131 RVA: 0x00258064 File Offset: 0x00256264
		// (set) Token: 0x0600910C RID: 37132 RVA: 0x00046154 File Offset: 0x00044354
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x00258094 File Offset: 0x00256294
		// (set) Token: 0x0600910E RID: 37134 RVA: 0x00046173 File Offset: 0x00044373
		public unsafe List<Text> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600910F RID: 37135 RVA: 0x002580C4 File Offset: 0x002562C4
		// (set) Token: 0x06009110 RID: 37136 RVA: 0x00046192 File Offset: 0x00044392
		public unsafe List<Text> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006208 RID: 25096
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04006209 RID: 25097
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x0400620A RID: 25098
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x0400620B RID: 25099
		private static readonly IntPtr NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0;

		// Token: 0x0400620C RID: 25100
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x0400620D RID: 25101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
