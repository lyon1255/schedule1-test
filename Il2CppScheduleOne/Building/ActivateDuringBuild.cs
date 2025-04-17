using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B1 RID: 1201
	public class ActivateDuringBuild : MonoBehaviour
	{
		// Token: 0x060069B6 RID: 27062 RVA: 0x00031F7E File Offset: 0x0003017E
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateDuringBuild()
		{
			Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "ActivateDuringBuild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr);
			ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr, 100676719);
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x001D90B4 File Offset: 0x001D72B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateDuringBuild() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00031FB7 File Offset: 0x000301B7
		public ActivateDuringBuild(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004867 RID: 18535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
