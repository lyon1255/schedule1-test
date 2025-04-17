using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200036F RID: 879
	public class TransportInitializer : MonoBehaviour
	{
		// Token: 0x060044B4 RID: 17588 RVA: 0x001531E8 File Offset: 0x001513E8
		// Note: this type is marked as 'beforefieldinit'.
		static TransportInitializer()
		{
			Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "TransportInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr);
			TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100671688);
			TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100671689);
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00153240 File Offset: 0x00151440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155436, XrefRangeEnd = 155446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x00153274 File Offset: 0x00151474
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x000218A8 File Offset: 0x0001FAA8
		public TransportInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
