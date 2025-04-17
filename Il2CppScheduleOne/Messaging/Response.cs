using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000376 RID: 886
	[Serializable]
	public class Response : Object
	{
		// Token: 0x06004598 RID: 17816 RVA: 0x00156F60 File Offset: 0x00155160
		// Note: this type is marked as 'beforefieldinit'.
		static Response()
		{
			Il2CppClassPointerStore<Response>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Response");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Response>.NativeClassPtr);
			Response.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "text");
			Response.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "label");
			Response.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "callback");
			Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "disableDefaultResponseBehaviour");
			Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100671860);
			Response.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100671861);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00157008 File Offset: 0x00155208
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157483, RefRangeEnd = 157488, XrefRangeStart = 157479, XrefRangeEnd = 157483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response(string _text, string _label, Action _callback = null, bool _disableDefaultResponseBehaviour = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _disableDefaultResponseBehaviour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00157088 File Offset: 0x00155288
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00021DB7 File Offset: 0x0001FFB7
		public Response(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x001570C4 File Offset: 0x001552C4
		// (set) Token: 0x0600459D RID: 17821 RVA: 0x00021DC0 File Offset: 0x0001FFC0
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x001570EC File Offset: 0x001552EC
		// (set) Token: 0x0600459F RID: 17823 RVA: 0x00021DDF File Offset: 0x0001FFDF
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x00157114 File Offset: 0x00155314
		// (set) Token: 0x060045A1 RID: 17825 RVA: 0x00021DFE File Offset: 0x0001FFFE
		public unsafe Action callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x00157144 File Offset: 0x00155344
		// (set) Token: 0x060045A3 RID: 17827 RVA: 0x00021E1D File Offset: 0x0002001D
		public unsafe bool disableDefaultResponseBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour)) = value;
			}
		}

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeFieldInfoPtr_disableDefaultResponseBehaviour;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
