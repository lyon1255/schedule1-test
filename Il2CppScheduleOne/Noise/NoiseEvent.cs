using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200036A RID: 874
	public class NoiseEvent : Il2CppSystem.Object
	{
		// Token: 0x06004463 RID: 17507 RVA: 0x00152258 File Offset: 0x00150458
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseEvent()
		{
			Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr);
			NoiseEvent.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "origin");
			NoiseEvent.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "range");
			NoiseEvent.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "type");
			NoiseEvent.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "source");
			NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, 100671654);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x001522EC File Offset: 0x001504EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154877, XrefRangeEnd = 154879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, GameObject _source = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _range;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00021621 File Offset: 0x0001F821
		public NoiseEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x00152364 File Offset: 0x00150564
		// (set) Token: 0x06004467 RID: 17511 RVA: 0x0002162A File Offset: 0x0001F82A
		public unsafe Vector3 origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x0015238C File Offset: 0x0015058C
		// (set) Token: 0x06004469 RID: 17513 RVA: 0x00021645 File Offset: 0x0001F845
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x001523B4 File Offset: 0x001505B4
		// (set) Token: 0x0600446B RID: 17515 RVA: 0x00021660 File Offset: 0x0001F860
		public unsafe ENoiseType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x001523DC File Offset: 0x001505DC
		// (set) Token: 0x0600446D RID: 17517 RVA: 0x0002167B File Offset: 0x0001F87B
		public unsafe GameObject source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0;
	}
}
