using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A7 RID: 935
	public class TransitRouteMaterial : MonoBehaviour
	{
		// Token: 0x0600493D RID: 18749 RVA: 0x001653A0 File Offset: 0x001635A0
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRouteMaterial()
		{
			Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRouteMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr);
			TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100672380);
			TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100672381);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001653F8 File Offset: 0x001635F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163083, XrefRangeEnd = 163092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x0016542C File Offset: 0x0016362C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRouteMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x000234C1 File Offset: 0x000216C1
		public TransitRouteMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
