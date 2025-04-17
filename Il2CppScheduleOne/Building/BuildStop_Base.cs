using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B9 RID: 1209
	public class BuildStop_Base : MonoBehaviour
	{
		// Token: 0x06006A00 RID: 27136 RVA: 0x001DA390 File Offset: 0x001D8590
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStop_Base()
		{
			Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr);
			BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100676762);
			BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100676763);
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x001DA3E8 File Offset: 0x001D85E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213599, XrefRangeEnd = 213623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop_Building()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x001DA424 File Offset: 0x001D8624
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x00032112 File Offset: 0x00030312
		public BuildStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004898 RID: 18584
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0;

		// Token: 0x04004899 RID: 18585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
