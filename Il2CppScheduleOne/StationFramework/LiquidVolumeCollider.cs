using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058D RID: 1421
	public class LiquidVolumeCollider : MonoBehaviour
	{
		// Token: 0x06007D11 RID: 32017 RVA: 0x00218ABC File Offset: 0x00216CBC
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeCollider()
		{
			Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidVolumeCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr);
			LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, "LiquidContainer");
			LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100678957);
			LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100678958);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x00218B28 File Offset: 0x00216D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237590, XrefRangeEnd = 237598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x00218B5C File Offset: 0x00216D5C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x0003B65C File Offset: 0x0003985C
		public LiquidVolumeCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x06007D15 RID: 32021 RVA: 0x00218B98 File Offset: 0x00216D98
		// (set) Token: 0x06007D16 RID: 32022 RVA: 0x0003B665 File Offset: 0x00039865
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400551C RID: 21788
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x0400551D RID: 21789
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400551E RID: 21790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
