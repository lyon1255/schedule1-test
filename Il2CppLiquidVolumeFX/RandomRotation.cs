using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CA RID: 202
	public class RandomRotation : MonoBehaviour
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0009FDF8 File Offset: 0x0009DFF8
		// Note: this type is marked as 'beforefieldinit'.
		static RandomRotation()
		{
			Il2CppClassPointerStore<RandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "RandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr);
			RandomRotation.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "speed");
			RandomRotation.NativeFieldInfoPtr_randomChangeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "randomChangeInterval");
			RandomRotation.NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "lastTime");
			RandomRotation.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "v");
			RandomRotation.NativeFieldInfoPtr_randomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "randomization");
			RandomRotation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100665073);
			RandomRotation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100665074);
			RandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100665075);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0009FEC8 File Offset: 0x0009E0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86066, XrefRangeEnd = 86067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0009FEFC File Offset: 0x0009E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86067, XrefRangeEnd = 86075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0009FF30 File Offset: 0x0009E130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86075, XrefRangeEnd = 86076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00009585 File Offset: 0x00007785
		public RandomRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0009FF6C File Offset: 0x0009E16C
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0000958E File Offset: 0x0000778E
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0009FF94 File Offset: 0x0009E194
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000095A9 File Offset: 0x000077A9
		public unsafe float randomChangeInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomChangeInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomChangeInterval)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0009FFBC File Offset: 0x0009E1BC
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000095C4 File Offset: 0x000077C4
		public unsafe float lastTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_lastTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_lastTime)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0009FFE4 File Offset: 0x0009E1E4
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x000095DF File Offset: 0x000077DF
		public unsafe Vector3 v
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_v);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_v)) = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000A000C File Offset: 0x0009E20C
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x000095FA File Offset: 0x000077FA
		public unsafe float randomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomization)) = value;
			}
		}

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_randomChangeInterval;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_lastTime;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_v;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_randomization;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
