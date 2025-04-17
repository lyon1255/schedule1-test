using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000459 RID: 1113
	public class LookAt : MonoBehaviour
	{
		// Token: 0x060060AF RID: 24751 RVA: 0x001B9E04 File Offset: 0x001B8004
		// Note: this type is marked as 'beforefieldinit'.
		static LookAt()
		{
			Il2CppClassPointerStore<LookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAt>.NativeClassPtr);
			LookAt.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAt>.NativeClassPtr, "Target");
			LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675597);
			LookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675598);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x001B9E70 File Offset: 0x001B8070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199390, XrefRangeEnd = 199396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x001B9EA4 File Offset: 0x001B80A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x0002DB93 File Offset: 0x0002BD93
		public LookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x060060B3 RID: 24755 RVA: 0x001B9EE0 File Offset: 0x001B80E0
		// (set) Token: 0x060060B4 RID: 24756 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041FE RID: 16894
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040041FF RID: 16895
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004200 RID: 16896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
