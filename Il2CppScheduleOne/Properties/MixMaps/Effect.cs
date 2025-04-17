using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001F3 RID: 499
	public class Effect : MonoBehaviour
	{
		// Token: 0x0600287E RID: 10366 RVA: 0x000F0780 File Offset: 0x000EE980
		// Note: this type is marked as 'beforefieldinit'.
		static Effect()
		{
			Il2CppClassPointerStore<Effect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "Effect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Effect>.NativeClassPtr);
			Effect.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Property");
			Effect.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Radius");
			Effect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100667866);
			Effect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100667867);
			Effect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100667868);
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x000F0814 File Offset: 0x000EEA14
		public unsafe Vector2 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118529, XrefRangeEnd = 118533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000F0850 File Offset: 0x000EEA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118533, XrefRangeEnd = 118539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000F0884 File Offset: 0x000EEA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Effect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Effect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0001602B File Offset: 0x0001422B
		public Effect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x000F08C0 File Offset: 0x000EEAC0
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x00016034 File Offset: 0x00014234
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x000F08F0 File Offset: 0x000EEAF0
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x00016053 File Offset: 0x00014253
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
