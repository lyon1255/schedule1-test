using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052C RID: 1324
	public class BetaEnabledGameObject : MonoBehaviour
	{
		// Token: 0x06007646 RID: 30278 RVA: 0x002029A0 File Offset: 0x00200BA0
		// Note: this type is marked as 'beforefieldinit'.
		static BetaEnabledGameObject()
		{
			Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "BetaEnabledGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr);
			BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100678193);
			BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100678194);
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x002029F8 File Offset: 0x00200BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230605, XrefRangeEnd = 230609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00202A2C File Offset: 0x00200C2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetaEnabledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x000380D7 File Offset: 0x000362D7
		public BetaEnabledGameObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050CE RID: 20686
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040050CF RID: 20687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
