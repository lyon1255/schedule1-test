using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000510 RID: 1296
	public class PropertyDisposalArea : MonoBehaviour
	{
		// Token: 0x0600732F RID: 29487 RVA: 0x001F70A4 File Offset: 0x001F52A4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDisposalArea()
		{
			Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyDisposalArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr);
			PropertyDisposalArea.NativeFieldInfoPtr_StandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "StandPoint");
			PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "TrashDropPoint");
			PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, 100677760);
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x001F7110 File Offset: 0x001F5310
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDisposalArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00036C80 File Offset: 0x00034E80
		public PropertyDisposalArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06007332 RID: 29490 RVA: 0x001F714C File Offset: 0x001F534C
		// (set) Token: 0x06007333 RID: 29491 RVA: 0x00036C89 File Offset: 0x00034E89
		public unsafe Transform StandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06007334 RID: 29492 RVA: 0x001F717C File Offset: 0x001F537C
		// (set) Token: 0x06007335 RID: 29493 RVA: 0x00036CA8 File Offset: 0x00034EA8
		public unsafe Transform TrashDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EA0 RID: 20128
		private static readonly IntPtr NativeFieldInfoPtr_StandPoint;

		// Token: 0x04004EA1 RID: 20129
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropPoint;

		// Token: 0x04004EA2 RID: 20130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
