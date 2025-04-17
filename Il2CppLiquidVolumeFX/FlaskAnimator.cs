using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CE RID: 206
	public class FlaskAnimator : MonoBehaviour
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x000A0658 File Offset: 0x0009E858
		// Note: this type is marked as 'beforefieldinit'.
		static FlaskAnimator()
		{
			Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "FlaskAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr);
			FlaskAnimator.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "speed");
			FlaskAnimator.NativeFieldInfoPtr_initialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "initialPosition");
			FlaskAnimator.NativeFieldInfoPtr_finalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "finalPosition");
			FlaskAnimator.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "duration");
			FlaskAnimator.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "delay");
			FlaskAnimator.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "level");
			FlaskAnimator.NativeFieldInfoPtr_minRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "minRange");
			FlaskAnimator.NativeFieldInfoPtr_maxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "maxRange");
			FlaskAnimator.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "acceleration");
			FlaskAnimator.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "rotationSpeed");
			FlaskAnimator.NativeFieldInfoPtr_alphaDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "alphaDuration");
			FlaskAnimator.NativeFieldInfoPtr_finalRefractionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "finalRefractionBlur");
			FlaskAnimator.NativeFieldInfoPtr_liquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "liquid");
			FlaskAnimator.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "direction");
			FlaskAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, 100665083);
			FlaskAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, 100665084);
			FlaskAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, 100665085);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000A07DC File Offset: 0x0009E9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86186, XrefRangeEnd = 86192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlaskAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000A0810 File Offset: 0x0009EA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86192, XrefRangeEnd = 86216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlaskAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x000A0844 File Offset: 0x0009EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86216, XrefRangeEnd = 86221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlaskAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlaskAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000097C5 File Offset: 0x000079C5
		public FlaskAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000A0880 File Offset: 0x0009EA80
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x000097CE File Offset: 0x000079CE
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000A08A8 File Offset: 0x0009EAA8
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x000097E9 File Offset: 0x000079E9
		public unsafe Vector3 initialPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_initialPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_initialPosition)) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x000A08D0 File Offset: 0x0009EAD0
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00009804 File Offset: 0x00007A04
		public unsafe Vector3 finalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalPosition)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000A08F8 File Offset: 0x0009EAF8
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x0000981F File Offset: 0x00007A1F
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000A0920 File Offset: 0x0009EB20
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x0000983A File Offset: 0x00007A3A
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000A0948 File Offset: 0x0009EB48
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00009855 File Offset: 0x00007A55
		public unsafe float level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000A0970 File Offset: 0x0009EB70
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00009870 File Offset: 0x00007A70
		public unsafe float minRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_minRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_minRange)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000A0998 File Offset: 0x0009EB98
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x0000988B File Offset: 0x00007A8B
		public unsafe float maxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_maxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_maxRange)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000A09C0 File Offset: 0x0009EBC0
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000098A6 File Offset: 0x00007AA6
		public unsafe float acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_acceleration)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000A09E8 File Offset: 0x0009EBE8
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000098C1 File Offset: 0x00007AC1
		public unsafe float rotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_rotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_rotationSpeed)) = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000A0A10 File Offset: 0x0009EC10
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x000098DC File Offset: 0x00007ADC
		public unsafe float alphaDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_alphaDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_alphaDuration)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000A0A38 File Offset: 0x0009EC38
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000098F7 File Offset: 0x00007AF7
		public unsafe float finalRefractionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalRefractionBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalRefractionBlur)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000A0A60 File Offset: 0x0009EC60
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00009912 File Offset: 0x00007B12
		public unsafe LiquidVolume liquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_liquid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_liquid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000A0A90 File Offset: 0x0009EC90
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00009931 File Offset: 0x00007B31
		public unsafe float direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_initialPosition;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_finalPosition;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_minRange;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_maxRange;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_acceleration;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_alphaDuration;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_finalRefractionBlur;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_liquid;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
