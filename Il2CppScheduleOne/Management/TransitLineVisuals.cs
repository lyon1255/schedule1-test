using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A5 RID: 933
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x0600491E RID: 18718 RVA: 0x00164CA0 File Offset: 0x00162EA0
		// Note: this type is marked as 'beforefieldinit'.
		static TransitLineVisuals()
		{
			Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitLineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr);
			TransitLineVisuals.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, "Renderer");
			TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672365);
			TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672366);
			TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672367);
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x00164D20 File Offset: 0x00162F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162933, RefRangeEnd = 162936, XrefRangeStart = 162932, XrefRangeEnd = 162933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourcePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x00164D60 File Offset: 0x00162F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162937, RefRangeEnd = 162939, XrefRangeStart = 162936, XrefRangeEnd = 162937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestinationPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00164DA0 File Offset: 0x00162FA0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitLineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x000233F5 File Offset: 0x000215F5
		public TransitLineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06004923 RID: 18723 RVA: 0x00164DDC File Offset: 0x00162FDC
		// (set) Token: 0x06004924 RID: 18724 RVA: 0x000233FE File Offset: 0x000215FE
		public unsafe LineRenderer Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeFieldInfoPtr_Renderer;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
