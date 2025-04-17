﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D0 RID: 208
	public class SpotlightAnimator : MonoBehaviour
	{
		// Token: 0x06000F5A RID: 3930 RVA: 0x000A0CB8 File Offset: 0x0009EEB8
		// Note: this type is marked as 'beforefieldinit'.
		static SpotlightAnimator()
		{
			Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "SpotlightAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr);
			SpotlightAnimator.NativeFieldInfoPtr_lightOnDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "lightOnDelay");
			SpotlightAnimator.NativeFieldInfoPtr_targetIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "targetIntensity");
			SpotlightAnimator.NativeFieldInfoPtr_initialIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "initialIntensity");
			SpotlightAnimator.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "duration");
			SpotlightAnimator.NativeFieldInfoPtr_nextColorInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "nextColorInterval");
			SpotlightAnimator.NativeFieldInfoPtr_colorChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "colorChangeDuration");
			SpotlightAnimator.NativeFieldInfoPtr_spotLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "spotLight");
			SpotlightAnimator.NativeFieldInfoPtr_lastColorChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "lastColorChange");
			SpotlightAnimator.NativeFieldInfoPtr_colorChangeStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "colorChangeStarted");
			SpotlightAnimator.NativeFieldInfoPtr_currentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "currentColor");
			SpotlightAnimator.NativeFieldInfoPtr_nextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "nextColor");
			SpotlightAnimator.NativeFieldInfoPtr_changingColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, "changingColor");
			SpotlightAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, 100665089);
			SpotlightAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, 100665090);
			SpotlightAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr, 100665091);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000A0E14 File Offset: 0x0009F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86236, XrefRangeEnd = 86242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000A0E48 File Offset: 0x0009F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86242, XrefRangeEnd = 86255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000A0E7C File Offset: 0x0009F07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86255, XrefRangeEnd = 86256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpotlightAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpotlightAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotlightAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000099C1 File Offset: 0x00007BC1
		public SpotlightAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000A0EB8 File Offset: 0x0009F0B8
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000099CA File Offset: 0x00007BCA
		public unsafe float lightOnDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_lightOnDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_lightOnDelay)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000A0EE0 File Offset: 0x0009F0E0
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000099E5 File Offset: 0x00007BE5
		public unsafe float targetIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_targetIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_targetIntensity)) = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000A0F08 File Offset: 0x0009F108
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00009A00 File Offset: 0x00007C00
		public unsafe float initialIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_initialIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_initialIntensity)) = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000A0F30 File Offset: 0x0009F130
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00009A1B File Offset: 0x00007C1B
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x000A0F58 File Offset: 0x0009F158
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00009A36 File Offset: 0x00007C36
		public unsafe float nextColorInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_nextColorInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_nextColorInterval)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x000A0F80 File Offset: 0x0009F180
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x00009A51 File Offset: 0x00007C51
		public unsafe float colorChangeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_colorChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_colorChangeDuration)) = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x000A0FA8 File Offset: 0x0009F1A8
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00009A6C File Offset: 0x00007C6C
		public unsafe Light spotLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_spotLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_spotLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x000A0FD8 File Offset: 0x0009F1D8
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x00009A8B File Offset: 0x00007C8B
		public unsafe float lastColorChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_lastColorChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_lastColorChange)) = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000A1000 File Offset: 0x0009F200
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00009AA6 File Offset: 0x00007CA6
		public unsafe float colorChangeStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_colorChangeStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_colorChangeStarted)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000A1028 File Offset: 0x0009F228
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00009AC1 File Offset: 0x00007CC1
		public unsafe Color currentColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_currentColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_currentColor)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x000A1050 File Offset: 0x0009F250
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00009ADC File Offset: 0x00007CDC
		public unsafe Color nextColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_nextColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_nextColor)) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000A1078 File Offset: 0x0009F278
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00009AF7 File Offset: 0x00007CF7
		public unsafe bool changingColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_changingColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpotlightAnimator.NativeFieldInfoPtr_changingColor)) = value;
			}
		}

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_lightOnDelay;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_targetIntensity;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr_initialIntensity;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_nextColorInterval;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_colorChangeDuration;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_spotLight;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_lastColorChange;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_colorChangeStarted;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_currentColor;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_nextColor;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_changingColor;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
