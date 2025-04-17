using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048A RID: 1162
	public class ConstructStop_Base : MonoBehaviour
	{
		// Token: 0x060064A2 RID: 25762 RVA: 0x001C7150 File Offset: 0x001C5350
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStop_Base()
		{
			Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr);
			ConstructStop_Base.NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr, 100676048);
			ConstructStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr, 100676049);
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x001C71A8 File Offset: 0x001C53A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204400, XrefRangeEnd = 204409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopConstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStop_Base.NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x001C71E4 File Offset: 0x001C53E4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x0002F95F File Offset: 0x0002DB5F
		public ConstructStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040044AA RID: 17578
		private static readonly IntPtr NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0;

		// Token: 0x040044AB RID: 17579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
