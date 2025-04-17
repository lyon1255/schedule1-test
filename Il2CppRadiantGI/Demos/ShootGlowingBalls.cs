using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRadiantGI.Demos
{
	// Token: 0x020000C7 RID: 199
	public class ShootGlowingBalls : MonoBehaviour
	{
		// Token: 0x06000ECB RID: 3787 RVA: 0x0009F7C0 File Offset: 0x0009D9C0
		// Note: this type is marked as 'beforefieldinit'.
		static ShootGlowingBalls()
		{
			Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RadiantGI.Demos", "ShootGlowingBalls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr);
			ShootGlowingBalls.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, "count");
			ShootGlowingBalls.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, "center");
			ShootGlowingBalls.NativeFieldInfoPtr_glowingBall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, "glowingBall");
			ShootGlowingBalls.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, 100665058);
			ShootGlowingBalls.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, 100665059);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0009F854 File Offset: 0x0009DA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85921, XrefRangeEnd = 85953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShootGlowingBalls.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0009F888 File Offset: 0x0009DA88
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShootGlowingBalls() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShootGlowingBalls.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0000941F File Offset: 0x0000761F
		public ShootGlowingBalls(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0009F8C4 File Offset: 0x0009DAC4
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00009428 File Offset: 0x00007628
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0009F8EC File Offset: 0x0009DAEC
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00009443 File Offset: 0x00007643
		public unsafe Transform center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0009F91C File Offset: 0x0009DB1C
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00009462 File Offset: 0x00007662
		public unsafe GameObject glowingBall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_glowingBall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_glowingBall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_glowingBall;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
