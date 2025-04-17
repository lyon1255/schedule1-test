using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D2 RID: 210
	public class RandomMove : MonoBehaviour
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x000A1258 File Offset: 0x0009F458
		// Note: this type is marked as 'beforefieldinit'.
		static RandomMove()
		{
			Il2CppClassPointerStore<RandomMove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "RandomMove");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomMove>.NativeClassPtr);
			RandomMove.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "right");
			RandomMove.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "left");
			RandomMove.NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "back");
			RandomMove.NativeFieldInfoPtr_front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "front");
			RandomMove.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "speed");
			RandomMove.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "rotationSpeed");
			RandomMove.NativeFieldInfoPtr_randomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "randomSpeed");
			RandomMove.NativeFieldInfoPtr_automatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "automatic");
			RandomMove.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "velocity");
			RandomMove.NativeFieldInfoPtr_flaskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, "flaskType");
			RandomMove.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, 100665094);
			RandomMove.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMove>.NativeClassPtr, 100665095);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000A1378 File Offset: 0x0009F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86265, XrefRangeEnd = 86350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMove.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000A13AC File Offset: 0x0009F5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86350, XrefRangeEnd = 86353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomMove() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomMove>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMove.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00009B87 File Offset: 0x00007D87
		public RandomMove(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000A13E8 File Offset: 0x0009F5E8
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x00009B90 File Offset: 0x00007D90
		public unsafe float right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_right);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_right)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000A1410 File Offset: 0x0009F610
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x00009BAB File Offset: 0x00007DAB
		public unsafe float left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_left);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_left)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x000A1438 File Offset: 0x0009F638
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00009BC6 File Offset: 0x00007DC6
		public unsafe float back
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_back);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_back)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000A1460 File Offset: 0x0009F660
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00009BE1 File Offset: 0x00007DE1
		public unsafe float front
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_front);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_front)) = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000A1488 File Offset: 0x0009F688
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00009BFC File Offset: 0x00007DFC
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000A14B0 File Offset: 0x0009F6B0
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00009C17 File Offset: 0x00007E17
		public unsafe float rotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_rotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_rotationSpeed)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000A14D8 File Offset: 0x0009F6D8
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00009C32 File Offset: 0x00007E32
		public unsafe float randomSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_randomSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_randomSpeed)) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x000A1500 File Offset: 0x0009F700
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00009C4D File Offset: 0x00007E4D
		public unsafe bool automatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_automatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_automatic)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x000A1528 File Offset: 0x0009F728
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00009C68 File Offset: 0x00007E68
		public unsafe Vector3 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x000A1550 File Offset: 0x0009F750
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00009C83 File Offset: 0x00007E83
		public unsafe int flaskType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_flaskType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMove.NativeFieldInfoPtr_flaskType)) = value;
			}
		}

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_back;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_front;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_randomSpeed;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_automatic;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_flaskType;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
