using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000443 RID: 1091
	[Serializable]
	public class BranchNodeData : Il2CppSystem.Object
	{
		// Token: 0x06005F53 RID: 24403 RVA: 0x001B602C File Offset: 0x001B422C
		// Note: this type is marked as 'beforefieldinit'.
		static BranchNodeData()
		{
			Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr);
			BranchNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Guid");
			BranchNodeData.NativeFieldInfoPtr_BranchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "BranchLabel");
			BranchNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Position");
			BranchNodeData.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "options");
			BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, 100675468);
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x001B60C0 File Offset: 0x001B42C0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
		public BranchNodeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x001B60FC File Offset: 0x001B42FC
		// (set) Token: 0x06005F57 RID: 24407 RVA: 0x0002CEF1 File Offset: 0x0002B0F1
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x001B6124 File Offset: 0x001B4324
		// (set) Token: 0x06005F59 RID: 24409 RVA: 0x0002CF10 File Offset: 0x0002B110
		public unsafe string BranchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x001B614C File Offset: 0x001B434C
		// (set) Token: 0x06005F5B RID: 24411 RVA: 0x0002CF2F File Offset: 0x0002B12F
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06005F5C RID: 24412 RVA: 0x001B6174 File Offset: 0x001B4374
		// (set) Token: 0x06005F5D RID: 24413 RVA: 0x0002CF4A File Offset: 0x0002B14A
		public unsafe Il2CppReferenceArray<BranchOptionData> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BranchOptionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004132 RID: 16690
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004133 RID: 16691
		private static readonly IntPtr NativeFieldInfoPtr_BranchLabel;

		// Token: 0x04004134 RID: 16692
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04004135 RID: 16693
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04004136 RID: 16694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
