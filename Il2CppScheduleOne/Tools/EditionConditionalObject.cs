using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000536 RID: 1334
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x060076B8 RID: 30392 RVA: 0x00203E54 File Offset: 0x00202054
		// Note: this type is marked as 'beforefieldinit'.
		static EditionConditionalObject()
		{
			Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EditionConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr);
			EditionConditionalObject.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, "type");
			EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100678248);
			EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100678249);
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00203EC0 File Offset: 0x002020C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230948, XrefRangeEnd = 230950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00203EF4 File Offset: 0x002020F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditionConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00038421 File Offset: 0x00036621
		public EditionConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x060076BC RID: 30396 RVA: 0x00203F30 File Offset: 0x00202130
		// (set) Token: 0x060076BD RID: 30397 RVA: 0x0003842A File Offset: 0x0003662A
		public unsafe EditionConditionalObject.EType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04005111 RID: 20753
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04005112 RID: 20754
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005113 RID: 20755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9C RID: 2716
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04008E24 RID: 36388
			ActiveInDemo,
			// Token: 0x04008E25 RID: 36389
			ActiveInFullGame
		}
	}
}
