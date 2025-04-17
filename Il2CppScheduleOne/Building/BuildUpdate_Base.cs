using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BA RID: 1210
	public class BuildUpdate_Base : MonoBehaviour
	{
		// Token: 0x06006A04 RID: 27140 RVA: 0x001DA460 File Offset: 0x001D8660
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Base()
		{
			Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr);
			BuildUpdate_Base.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr, 100676764);
			BuildUpdate_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr, 100676765);
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x001DA4B8 File Offset: 0x001D86B8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Base.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x001DA4F4 File Offset: 0x001D86F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x0003211B File Offset: 0x0003031B
		public BuildUpdate_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400489A RID: 18586
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x0400489B RID: 18587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
