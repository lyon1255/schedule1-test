using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001F5 RID: 501
	[Serializable]
	public class MixerMapEffect : Il2CppSystem.Object
	{
		// Token: 0x06002890 RID: 10384 RVA: 0x000F0ADC File Offset: 0x000EECDC
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapEffect()
		{
			Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMapEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr);
			MixerMapEffect.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Position");
			MixerMapEffect.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Radius");
			MixerMapEffect.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Property");
			MixerMapEffect.NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, 100667872);
			MixerMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, 100667873);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000F0B70 File Offset: 0x000EED70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118569, XrefRangeEnd = 118574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInEffect(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapEffect.NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000F0BBC File Offset: 0x000EEDBC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000160B1 File Offset: 0x000142B1
		public MixerMapEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000F0BF8 File Offset: 0x000EEDF8
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x000160BA File Offset: 0x000142BA
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000F0C20 File Offset: 0x000EEE20
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x000160D5 File Offset: 0x000142D5
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000F0C48 File Offset: 0x000EEE48
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x000160F0 File Offset: 0x000142F0
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
