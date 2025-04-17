using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000041 RID: 65
	public class SwooshTest : MonoBehaviour
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x0007F900 File Offset: 0x0007DB00
		// Note: this type is marked as 'beforefieldinit'.
		static SwooshTest()
		{
			Il2CppClassPointerStore<SwooshTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwooshTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr);
			SwooshTest.NativeFieldInfoPtr__animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_animation");
			SwooshTest.NativeFieldInfoPtr__animationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_animationState");
			SwooshTest.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_start");
			SwooshTest.NativeFieldInfoPtr__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_end");
			SwooshTest.NativeFieldInfoPtr__startN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_startN");
			SwooshTest.NativeFieldInfoPtr__endN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_endN");
			SwooshTest.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_time");
			SwooshTest.NativeFieldInfoPtr__prevTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_prevTime");
			SwooshTest.NativeFieldInfoPtr__prevAnimTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_prevAnimTime");
			SwooshTest.NativeFieldInfoPtr__trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_trail");
			SwooshTest.NativeFieldInfoPtr__firstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_firstFrame");
			SwooshTest.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, 100663742);
			SwooshTest.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, 100663743);
			SwooshTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, 100663744);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0007FA48 File Offset: 0x0007DC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74795, XrefRangeEnd = 74803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwooshTest.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0007FA7C File Offset: 0x0007DC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74803, XrefRangeEnd = 74806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwooshTest.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0007FAB0 File Offset: 0x0007DCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74806, XrefRangeEnd = 74807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwooshTest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwooshTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00005261 File Offset: 0x00003461
		public SwooshTest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0007FAEC File Offset: 0x0007DCEC
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x0000526A File Offset: 0x0000346A
		public unsafe AnimationClip _animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0007FB1C File Offset: 0x0007DD1C
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00005289 File Offset: 0x00003489
		public unsafe AnimationState _animationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animationState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animationState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0007FB4C File Offset: 0x0007DD4C
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x000052A8 File Offset: 0x000034A8
		public unsafe int _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__start)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0007FB74 File Offset: 0x0007DD74
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x000052C3 File Offset: 0x000034C3
		public unsafe int _end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__end)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0007FB9C File Offset: 0x0007DD9C
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x000052DE File Offset: 0x000034DE
		public unsafe float _startN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__startN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__startN)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0007FBC4 File Offset: 0x0007DDC4
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000052F9 File Offset: 0x000034F9
		public unsafe float _endN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__endN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__endN)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0007FBEC File Offset: 0x0007DDEC
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00005314 File Offset: 0x00003514
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0007FC14 File Offset: 0x0007DE14
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0000532F File Offset: 0x0000352F
		public unsafe float _prevTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevTime)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0007FC3C File Offset: 0x0007DE3C
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000534A File Offset: 0x0000354A
		public unsafe float _prevAnimTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevAnimTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevAnimTime)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0007FC64 File Offset: 0x0007DE64
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00005365 File Offset: 0x00003565
		public unsafe MeleeWeaponTrail _trail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__trail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeleeWeaponTrail>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__trail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0007FC94 File Offset: 0x0007DE94
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00005384 File Offset: 0x00003584
		public unsafe bool _firstFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__firstFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__firstFrame)) = value;
			}
		}

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr__animation;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr__animationState;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr__end;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr__startN;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr__endN;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr__prevTime;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr__prevAnimTime;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr__trail;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr__firstFrame;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
