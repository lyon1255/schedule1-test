﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000188 RID: 392
	public class PongPaddle : MonoBehaviour
	{
		// Token: 0x06001F78 RID: 8056 RVA: 0x000D2998 File Offset: 0x000D0B98
		// Note: this type is marked as 'beforefieldinit'.
		static PongPaddle()
		{
			Il2CppClassPointerStore<PongPaddle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "PongPaddle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr);
			PongPaddle.NativeFieldInfoPtr_BOUND_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "BOUND_Y");
			PongPaddle.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "MOVE_SPEED");
			PongPaddle.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "SpeedMultiplier");
			PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "<TargetY>k__BackingField");
			PongPaddle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "Rect");
			PongPaddle.NativeMethodInfoPtr_get_TargetY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666840);
			PongPaddle.NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666841);
			PongPaddle.NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666842);
			PongPaddle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666843);
			PongPaddle.NativeMethodInfoPtr_UpdateMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666844);
			PongPaddle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666845);
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000D2AA4 File Offset: 0x000D0CA4
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x000D2AE0 File Offset: 0x000D0CE0
		public unsafe float TargetY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_get_TargetY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000D2B20 File Offset: 0x000D0D20
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetY(float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000D2B60 File Offset: 0x000D0D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108186, XrefRangeEnd = 108193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000D2B94 File Offset: 0x000D0D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_UpdateMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000D2BC8 File Offset: 0x000D0DC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74368, XrefRangeEnd = 74372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongPaddle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00011B48 File Offset: 0x0000FD48
		public PongPaddle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x000D2C04 File Offset: 0x000D0E04
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00011B51 File Offset: 0x0000FD51
		public unsafe static float BOUND_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PongPaddle.NativeFieldInfoPtr_BOUND_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PongPaddle.NativeFieldInfoPtr_BOUND_Y, (void*)(&value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000D2C20 File Offset: 0x000D0E20
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x00011B5F File Offset: 0x0000FD5F
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PongPaddle.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PongPaddle.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000D2C3C File Offset: 0x000D0E3C
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x00011B6D File Offset: 0x0000FD6D
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000D2C64 File Offset: 0x000D0E64
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00011B88 File Offset: 0x0000FD88
		public unsafe float _TargetY_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x000D2C8C File Offset: 0x000D0E8C
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00011BA3 File Offset: 0x0000FDA3
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeFieldInfoPtr_BOUND_Y;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeFieldInfoPtr__TargetY_k__BackingField;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetY_Public_get_Single_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMove_Private_Void_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
