using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046E RID: 1134
	public class GUIDUtility : MonoBehaviour
	{
		// Token: 0x06006239 RID: 25145 RVA: 0x001BEF10 File Offset: 0x001BD110
		// Note: this type is marked as 'beforefieldinit'.
		static GUIDUtility()
		{
			Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GUIDUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr);
			GUIDUtility.NativeMethodInfoPtr_GenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr, 100675763);
			GUIDUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr, 100675764);
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x001BEF68 File Offset: 0x001BD168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201858, XrefRangeEnd = 201864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDUtility.NativeMethodInfoPtr_GenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x001BEF9C File Offset: 0x001BD19C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIDUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x0002E69F File Offset: 0x0002C89F
		public GUIDUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040042F9 RID: 17145
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGUID_Public_Void_0;

		// Token: 0x040042FA RID: 17146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
